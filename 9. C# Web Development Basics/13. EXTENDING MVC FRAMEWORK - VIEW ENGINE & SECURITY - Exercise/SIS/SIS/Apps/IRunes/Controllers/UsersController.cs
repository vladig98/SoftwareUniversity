using IRunes.Data;
using IRunes.Models;
using IRunes.Services;
using IRunes.ViewModels;
using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Action;
using SIS.Framework.Attributes.Methods;
using SIS.Framework.Controllers;
using SIS.Framework.Models;
using SIS.Framework.Security;
using SIS.Framework.Views;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Exceptions;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace IRunes.Controllers
{
    public class UsersController : BaseController
    {
        private IEncryptionService encryptionService;
        private readonly IRunesDbContext context;

        public UsersController(IRunesDbContext context, IEncryptionService encryptionService)
        {
            this.context = context;
            this.encryptionService = encryptionService;
        }

        public IActionResult Login()
        {
            if (Identity != null)
            {
                Model.Data["Error"] = "You are already logged in!";
                return View();
            }

            return View();
        }

        public IActionResult Register()
        {
            if (Identity != null)
            {
                Model.Data["Error"] = "You are already logged in!";
                return View();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (Identity != null)
            {
                Model.Data["Error"] = "You are already logged in!";
                return View();
            }

            string username = model.username;
            string password = model.password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            var user = context.Users.FirstOrDefault(x => x.Username == username || x.Email == username);

            if (user == null)
            {
                Model.Data["Error"] = "User does not exist!";
                return View();
            }

            password = encryptionService.Encrypt(password);

            if (user.Password != password)
            {
                Model.Data["Error"] = "Bad credentials!";
                return View();
            }

            SignIn(new IdentityUser
            {
                Username = username,
                //Password = password,
                Email = username
            });

            return RedirectToAction("/Home/Index");
        }

        public IActionResult Logout()
        {
            if (Identity == null)
            {
                Model.Data["Error"] = "You need to log in first!";
                return View();
            }

            SignOut();

            return RedirectToAction("/Home/Index");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (Identity != null)
            {
                Model.Data["Error"] = "You are already logged in!";
                return View();
            }

            string username = model.username;
            string password = model.password;
            string confirmPassword = model.confirmPassword;
            string email = model.email;

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrWhiteSpace(confirmPassword)
                || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            email = HttpUtility.UrlDecode(email);

            if (!email.Contains("@"))
            {
                Model.Data["Error"] = "Invalid data!";
                return View();
            }

            if (context.Users.Any(x => x.Username == username || x.Email == email))
            {
                Model.Data["Error"] = "User already exists!";
                return View();
            }

            if (password != confirmPassword)
            {
                Model.Data["Error"] = "Passwords do not match!";
                return View();
            }

            password = encryptionService.Encrypt(password);

            var response = new SIS.WebServer.Results.RedirectResult("/");

            User user = new User
            {
                Email = email,
                Password = password,
                Username = username,
                Id = Guid.NewGuid().ToString()
            };

            context.Users.Add(user);
            context.SaveChanges();

            SignIn(new IdentityUser
            {
                Email = email,
                Username = username
            });

            return RedirectToAction("/Home/Index");
        }
    }
}
