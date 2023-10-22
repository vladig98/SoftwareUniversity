using AutoMapper;
using Eventures.DbModels;
using Eventures.DbModels.Enums;
using Eventures.Filters;
using Eventures.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Claims;
using System.Text;

namespace Eventures.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UsersController(SignInManager<User> signInManager, UserManager<User> userManager,
            IUserStore<User> userStore, ILogger<UsersController> logger, IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(FinishExternalLogin), values: new { returnUrl });

            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }

        public IActionResult ExternalLogin()
        {
            return Redirect("/Users/Login");
        }

        public async Task<IActionResult> FinishExternalLogin(string returnUrl = null, string remoteError = null)
        {
            ExternalLoginViewModel model = new ExternalLoginViewModel();

            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                return RedirectToPage("/Users/Login", new { ReturnUrl = returnUrl });
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToPage("/Users/Login", new { ReturnUrl = returnUrl });
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
                return LocalRedirect(returnUrl);
            }


            model.ReturnUrl = returnUrl;
            model.ProviderDisplayName = info.ProviderDisplayName;
            if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
            {
                model.Email = info.Principal.FindFirstValue(ClaimTypes.Email);
            }
            if (info.Principal.Identity.Name != null)
            {
                model.FirstName = info.Principal.Identity.Name.Split(" ")[0];
                model.LastName = info.Principal.Identity.Name.Split(" ").Length > 1 ? info.Principal.Identity.Name.Split(" ")[1] : "";
            }

            return View("ExternalLogin", model);
        }

        [HttpPost]
        public async Task<IActionResult> FinishExternalLogin(ExternalLoginViewModel model, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            // Get the information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToPage("/Users/Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                User user = _mapper.Map<ExternalLoginViewModel, User>(model);

                await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);

                var result = await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user, Role.User.ToString());
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created an account using {Name} provider.", info.LoginProvider);

                        var userId = await _userManager.GetUserIdAsync(user);
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                        await _signInManager.SignInAsync(user, isPersistent: false, info.LoginProvider);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            model.ProviderDisplayName = info.ProviderDisplayName;
            model.ReturnUrl = returnUrl;
            return Redirect("/Home/Index");
        }

        [TypeFilter(typeof(AlreadyAuthorizedActionFilter))]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            var model = new LoginViewModel();

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [TypeFilter(typeof(AlreadyAuthorizedActionFilter))]
        public IActionResult Register()
        {
            return View();
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            _logger.LogInformation("User successfully logged out!");

            return Redirect("/Home/Index");
        }

        [HttpPost]
        [TypeFilter(typeof(AlreadyAuthorizedActionFilter))]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                _logger.LogError("User already exists!");
                return BadRequest();
            }

            user = _mapper.Map<RegisterViewModel, User>(model);

            await _userStore.SetUserNameAsync(user, model.UserName, CancellationToken.None);

            _logger.LogInformation("UserName set!");

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                _logger.LogError("Cannot create the user!");
                return StatusCode(500);
            }

            _logger.LogInformation("User created successfully!");

            await _userManager.AddToRoleAsync(user, Role.User.ToString());

            _logger.LogInformation($"User {user.UserName} attached to role {Role.User.ToString()}!");

            await _signInManager.SignInAsync(user, isPersistent: false);

            _logger.LogInformation("User signed in!");

            return Redirect("/Home/Index");
        }

        [HttpPost]
        [TypeFilter(typeof(AlreadyAuthorizedActionFilter))]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                _logger.LogError("Bad credentials!");
                return BadRequest();
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                _logger.LogError("Bad credentials!");
                return BadRequest();
            }

            _logger.LogInformation("User logged in successfully!");

            return Redirect("/Home/Index");
        }
    }
}
