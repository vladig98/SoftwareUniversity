using ByTheCake.Data;
using ByTheCake.Models;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ByTheCake.Controllers
{
    public class CakesController
    {
        private const string PathToViews = "../../../Views/";
        private readonly ByTheCakeDbContext context;

        public CakesController()
        {
            context = new ByTheCakeDbContext();
        }

        public IHttpResponse ShowCake(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            string content = File.ReadAllText(PathToViews + "ShowCake.html");

            int cakeId = int.Parse(request.URL.Split("/").Last().Split("?").First());

            var cake = context.Products.FirstOrDefault(x => x.Id == cakeId);

            content = content.Replace(@"{{name}}", cake.Name);
            content = content.Replace(@"{{price}}", cake.Price.ToString());
            content = content.Replace(@"{{imageURL}}", HttpUtility.UrlDecode(cake.ImageURL));

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse SearchPost(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var cakeName = request.FormData["name"].ToString();

            if (string.IsNullOrEmpty(cakeName) || string.IsNullOrWhiteSpace(cakeName))
            {
                return new RedirectResult("/search");
            }

            var cake = context.Products.FirstOrDefault(x => x.Name == cakeName);

            if (cake == null)
            {
                return new HtmlResult("<h1>Cake Not Found</h1>", HttpResponseStatusCode.BadRequest);
            }

            return new RedirectResult("/cakeDetails/" + cake.Id.ToString());
        }

        public IHttpResponse Order(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            int cakeId = int.Parse(request.URL.Split("/").Last().Split("?").First());

            var cake = context.Products.FirstOrDefault(y => y.Id == cakeId);

            Dictionary<string, int> cart = new Dictionary<string, int>();

            if (request.Cookies.ContainsCookie("cart"))
            {
                var cookie = request.Cookies.GetCookie("cart").Value.Split(" ");

                foreach (var item in cookie)
                {
                    var itemTokens = item.Split("=");

                    cart.Add(itemTokens[0], int.Parse(itemTokens[1]));
                }
            }

            if (cart.ContainsKey(cake.Name))
            {
                cart[cake.Name]++;
            }
            else
            {
                cart.Add(cake.Name, 1);
            }

            var respone = new RedirectResult("/cart");

            respone.Cookies.Add(new HttpCookie("cart", string.Join(" ", cart.Select(x => x.Key + "=" + x.Value))));

            return respone;
        }

        public IHttpResponse Search(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            string content = File.ReadAllText(PathToViews + "Search.html");

            int index = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            var template = content.Substring(index, endIndex - index + 3);

            List<string> templates = new List<string>();

            var cakes = context.Products.ToList();

            foreach (var cake in cakes)
            {
                var newTemplate = template;

                newTemplate = newTemplate.Replace("{{{", string.Empty);
                newTemplate = newTemplate.Replace("}}}", string.Empty);

                newTemplate = newTemplate.Replace(@"{{cakeId}}", cake.Id.ToString());
                newTemplate = newTemplate.Replace(@"{{cakeName}}", cake.Name);
                newTemplate = newTemplate.Replace(@"{{cakePrice}}", cake.Price.ToString());
                newTemplate = newTemplate.Replace(@"{{orderLink}}", "/order/" + cake.Id.ToString());

                templates.Add(newTemplate);
            }

            content = content.Replace(template, string.Join("\r\n", templates));

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse Add(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            string content = File.ReadAllText(PathToViews + "AddCake.html");

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse AddCake(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var formData = request.FormData;

            var name = formData["name"].ToString();
            var price = formData["price"].ToString();
            var imageUrl = formData["pictureURL"].ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return new HtmlResult("<h1>Invalid name</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
            {
                return new HtmlResult("<h1>Invalid price</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (string.IsNullOrEmpty(imageUrl) || string.IsNullOrWhiteSpace(imageUrl))
            {
                return new HtmlResult("<h1>Invalid URL</h1>", HttpResponseStatusCode.BadRequest);
            }

            var isPriceValid = decimal.TryParse(price, out decimal parsedPrice);

            if (!isPriceValid)
            {
                return new HtmlResult("<h1>Invalid price</h1>", HttpResponseStatusCode.BadRequest);
            }

            if (parsedPrice <= 0)
            {
                return new HtmlResult("<h1>Invalid price</h1>", HttpResponseStatusCode.BadRequest);
            }

            context.Products.Add(new Product
            {
                Name = name,
                Price = parsedPrice,
                ImageURL = imageUrl
            });

            context.SaveChanges();

            return new RedirectResult("/");
        }
    }
}
