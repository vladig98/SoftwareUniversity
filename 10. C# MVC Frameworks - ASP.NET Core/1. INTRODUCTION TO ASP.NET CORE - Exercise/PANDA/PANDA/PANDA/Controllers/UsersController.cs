using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PANDA.Data;
using PANDA.DbModels;
using PANDA.DbModels.Enums;
using PANDA.Models;

namespace PANDA.Controllers
{
    public class UsersController : Controller
    {
        private readonly PandaDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(PandaDbContext context, SignInManager<User> signInManager,
            UserManager<User> userManager, IUserStore<User> userStore, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _roleManager = roleManager;
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

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.Username);

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
                Password = model.Password,
                UserName = model.Username,
                Id = Guid.NewGuid().ToString(),
                Role = role
            };

            var roleExists = await _roleManager.RoleExistsAsync(role.ToString());

            if (!roleExists)
            {
                var identityRole = new IdentityRole();
                identityRole.Name = role.ToString();

                await _roleManager.CreateAsync(identityRole);
            }

            await _userStore.SetUserNameAsync(user, model.Username, CancellationToken.None);

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

            var user = _context.Users.FirstOrDefault(x => x.UserName == model.Username);
            //var user = _userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                return Unauthorized();
            }

            if (user.Password != model.Password)
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
