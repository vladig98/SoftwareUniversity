using IRunes.Data;
using IRunes.Models;
using IRunes.Services;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace IRunes.Controllers
{
    public class UsersController
    {
        private const string PathToViews = "../../../Views/";
        private readonly IRunesDbContext context;

        public UsersController()
        {
            context = new IRunesDbContext();
        }

        public IHttpResponse Login(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are already logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "Login.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse Register(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are already logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string content = File.ReadAllText(PathToViews + "Register.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse LoginPost(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are already logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string username = request.FormData["username"].ToString();
            string password = request.FormData["password"].ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
            }

            var user = context.Users.FirstOrDefault(x => x.Username == username || x.Email == username);

            if (user == null)
            {
                return new HtmlResult("<h1 style=\"color: red;\">User does not exist</h1>", HttpResponseStatusCode.BadRequest);
            }

            password = EncryptionService.Encrypt(password);

            if (user.Password != password)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Bad Credentials</h1>", HttpResponseStatusCode.BadRequest);
            }

            var result = new RedirectResult("/");

            result.AddCookie(new HttpCookie(".auth", EncryptionService.Encode(username)));

            return result;
        }

        public IHttpResponse Logout(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are not logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            var response = new RedirectResult("/");

            var cookie = request.Cookies.GetCookie(".auth");

            cookie.Expire();

            response.Cookies.Add(cookie);

            return response;
        }

        public IHttpResponse RegisterPost(IHttpRequest request)
        {
            if (request.Cookies.ContainsCookie(".auth"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">You are already logged in.</h1>", HttpResponseStatusCode.BadRequest);
            }

            string username = request.FormData["username"].ToString();
            string password = request.FormData["password"].ToString();
            string confirmPassword = request.FormData["confirmPassword"].ToString();
            string email = request.FormData["email"].ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrWhiteSpace(confirmPassword)
                || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
            }

            email = HttpUtility.UrlDecode(email);

            if (!email.Contains("@"))
            {
                return new HtmlResult("<h1 style=\"color: red;\">Invalid data</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (context.Users.Any(x => x.Username == username || x.Email == email))
            {
                return new HtmlResult("<h1 style=\"color: red;\">User already exists.</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (password != confirmPassword)
            {
                return new HtmlResult("<h1 style=\"color: red;\">Passwords do not match.</h1>", HttpResponseStatusCode.BadRequest);
            }

            password = EncryptionService.Encrypt(password);

            var response = new RedirectResult("/");

            User user = new User
            {
                Email = email,
                Password = password,
                Username = username,
                Id = Guid.NewGuid().ToString()
            };

            context.Users.Add(user);
            context.SaveChanges();

            response.AddCookie(new HttpCookie(".auth", EncryptionService.Encode(username)));

            return response;
        }
    }
}
