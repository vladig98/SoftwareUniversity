using Eventures.DbModels.Enums;
using Eventures.DbModels;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eventures.Data;

namespace Eventures.Controllers
{
    public class UsersController : Controller
    {
        private readonly EventuresDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger _logger;

        public UsersController(EventuresDbContext context, SignInManager<User> signInManager, UserManager<User> userManager,
            IUserStore<User> userStore, RoleManager<IdentityRole> roleManager, ILogger<UsersController> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _roleManager = roleManager;
            _context = context;
            _logger = logger;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is already authenticated!");
                return Redirect("/Home/Error");
            }

            return View();
        }

        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is already authenticated!");
                return Redirect("/Home/Error");
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is not logged in and cannot logout!");
                return Redirect("/Home/Error");
            }

            await _signInManager.SignOutAsync();

            _logger.LogInformation("User successfully logged out!");

            return Redirect("/Home/Index");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is already authenticated!");
                return Redirect("/Home/Error");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid data!");
                return BadRequest();
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.UserName);

            if (user != null)
            {
                _logger.LogError("User already exists!");
                return BadRequest();
            }

            if (model.Password != model.ConfirmPassword)
            {
                _logger.LogError("Passwords do not match!");
                return BadRequest();
            }

            if (!model.Email.Contains("@") && model.Email.Length < 3)
            {
                _logger.LogError("Invalid email address!");
                return BadRequest();
            }

            var role = _context.Users.Any() ? Role.User : Role.Admin;

            user = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Id = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UCN = model.UCN,
                Role = role
            };

            var roleExists = await _roleManager.RoleExistsAsync(role.ToString());

            if (!roleExists)
            {
                var identityRole = new IdentityRole();
                identityRole.Name = role.ToString();

                var rolecreated = await _roleManager.CreateAsync(identityRole);

                _logger.LogInformation($"Role {identityRole.Name} created successfully!");
            }

            await _userStore.SetUserNameAsync(user, model.UserName, CancellationToken.None);

            _logger.LogInformation("User property set!");

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                _logger.LogError("Cannot create the user!");
                return BadRequest();
            }

            _logger.LogInformation("User created successfully!");

            await _userManager.AddToRoleAsync(user, role.ToString());

            _logger.LogInformation($"User {user.UserName} attached to role {role.ToString()}!");

            await _signInManager.SignInAsync(user, isPersistent: false);

            _logger.LogInformation("User signed in!");

            return Redirect("/Home/Index");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is already authenticated!");
                return Redirect("/Home/Error");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid data!");
                return BadRequest();
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.UserName);
            //var user = _userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                _logger.LogError("User does not exist!");
                return Unauthorized();
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                _logger.LogError("Cannot log in user!");
                return BadRequest();
            }

            _logger.LogInformation("User logged in successfully!");

            return Redirect("/Home/Index");
        }
    }
}
