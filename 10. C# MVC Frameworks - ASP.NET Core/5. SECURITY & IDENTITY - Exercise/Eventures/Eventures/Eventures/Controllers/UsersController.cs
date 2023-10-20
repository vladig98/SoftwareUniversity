using Eventures.DbModels;
using Eventures.DbModels.Enums;
using Eventures.Filters;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly ILogger _logger;

        public UsersController(SignInManager<User> signInManager, UserManager<User> userManager,
            IUserStore<User> userStore, ILogger<UsersController> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _logger = logger;
        }

        [TypeFilter(typeof(AlreadyAuthorizedActionFilter))]
        public IActionResult Login()
        {
            return View();
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

            user = new User()
            {
                Email = model.Email,
                Id = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UCN = model.UCN,
                Role = Role.User
            };

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
        public async Task<IActionResult> Login(LoginViewModel model)
        {
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
