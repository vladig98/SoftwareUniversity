using CHUSHKA.Data;
using CHUSHKA.DbModels;
using CHUSHKA.DbModels.Enums;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Controllers
{
    public class UsersController : Controller
    {
        private readonly CHUSHKADbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(CHUSHKADbContext context, SignInManager<User> signInManager, UserManager<User> userManager,
            IUserStore<User> userStore, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Error");
            }

            await _signInManager.SignOutAsync();

            return Redirect("/Home/Index");
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Error");
            }

            return View();
        }

        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Error");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Error");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.UserName);

            if (user != null)
            {
                return BadRequest();
            }

            if (model.Password != model.ConfirmPassword)
            {
                return BadRequest();
            }

            if (!model.Email.Contains("@") && model.Email.Length < 3)
            {
                return BadRequest();
            }

            var role = _context.Users.Any() ? Role.User : Role.Admin;

            user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                Id = Guid.NewGuid().ToString(),
                Role = role,
                FullName = model.FullName
            };

            var roleExists = await _roleManager.RoleExistsAsync(role.ToString());

            if (!roleExists)
            {
                var identityRole = new IdentityRole();
                identityRole.Name = role.ToString();

                var rolecreated = await _roleManager.CreateAsync(identityRole);
            }

            await _userStore.SetUserNameAsync(user, model.UserName, CancellationToken.None);

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            await _userManager.AddToRoleAsync(user, role.ToString());

            await _signInManager.SignInAsync(user, isPersistent: false);

            return Redirect("/Home/Index");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Error");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.UserName);
            //var user = _userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                return Unauthorized();
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            return Redirect("/Home/Index");
        }
    }
}
