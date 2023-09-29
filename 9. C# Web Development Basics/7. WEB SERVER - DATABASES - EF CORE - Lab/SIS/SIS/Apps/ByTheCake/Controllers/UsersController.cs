using ByTheCake.Data;
using ByTheCake.Models;
using Microsoft.EntityFrameworkCore;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.IO;
using System.Linq;

namespace ByTheCake.Controllers
{
    public class UsersController
    {
        private const string PathToViews = "../../../Views/";
        private readonly ByTheCakeDbContext context;

        public UsersController()
        {
            context = new ByTheCakeDbContext();
        }

        public IHttpResponse Logout(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var cookie = request.Cookies.GetCookie(".auth");

            cookie.Expire();

            var response = new RedirectResult("/");

            response.AddCookie(cookie);

            return response;
        }

        public IHttpResponse Profile(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var loggedInUser = request.Cookies.GetCookie(".auth").Value;

            var user = context.Users.Include(x => x.Orders).FirstOrDefault(x => x.Username == loggedInUser);

            string content = File.ReadAllText(PathToViews + "Profile.html");

            content = content.Replace(@"{{username}}", user.Username);
            content = content.Replace(@"{{registeredOn}}", user.DateOfRegistration.ToString());
            content = content.Replace(@"{{OrdersCount}}", user.Orders.Count().ToString());

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse Login(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            string content = File.ReadAllText(PathToViews + "Login.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse LoginPost(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1>Already logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var formdata = request.FormData;

            var username = formdata["username"].ToString();
            var password = formdata["password"].ToString();

            if (!context.Users.Any(x => x.Username == username))
            {
                return new RedirectResult("/register");
            }

            var user = context.Users.FirstOrDefault(x => x.Username == username);

            if (user.Password != password)
            {
                return new HtmlResult("<h1>Bad credentials.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var respone = new RedirectResult("/");

            respone.Cookies.Add(new HttpCookie(".auth", username));

            return respone;
        }

        public IHttpResponse Register(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            string content = File.ReadAllText(PathToViews + "Register.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse RegisterUser(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var formData = request.FormData;

            var name = formData["Name"].ToString();
            var passWord = formData["Password"].ToString();
            var confirmPassword = formData["ConfirmPassword"].ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return new HtmlResult("<h1>Please provide a valid name</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(passWord) || string.IsNullOrWhiteSpace(passWord))
            {
                return new HtmlResult("<h1>Please provide a valid Password</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(confirmPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                return new HtmlResult("<h1>Please provide a valid Password</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (context.Users.ToArray().Any(x => x.Username == name))
            {
                return new HtmlResult("<h1>User already exists</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (passWord != confirmPassword)
            {
                return new HtmlResult("<h1>Passwords should match</h1>", HttpResponseStatusCode.BadRequest);
            }

            context.Users.Add(new User
            {
                Username = name,
                Name = name,
                Password = passWord,
                DateOfRegistration = DateTime.UtcNow
            });

            context.SaveChanges();

            return new RedirectResult("/");
        }
    }
}
