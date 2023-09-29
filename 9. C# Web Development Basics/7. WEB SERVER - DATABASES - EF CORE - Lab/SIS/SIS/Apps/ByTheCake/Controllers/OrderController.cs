using ByTheCake.Data;
using ByTheCake.Models;
using Microsoft.EntityFrameworkCore;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ByTheCake.Controllers
{
    public class OrderController
    {
        private const string PathToViews = "../../../Views/";
        private readonly ByTheCakeDbContext context;

        public OrderController()
        {
            context = new ByTheCakeDbContext();
        }

        public IHttpResponse OrderDetails(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var orderId = request.Path.Split("/").Last().Split("?")[0];

            var validInt = int.TryParse(orderId, out int parsedOrderId);

            if (!validInt)
            {
                return new HtmlResult("<h1>Invalid order Id</h1>", HttpResponseStatusCode.BadRequest);
            }

            var order = context.Orders.Include(x => x.Products).ThenInclude(x => x.Product).FirstOrDefault(x => x.Id == parsedOrderId);

            var content = File.ReadAllText(PathToViews + "OrderDetails.html");

            int index = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            var template = content.Substring(index, endIndex - index + 3);

            List<string> templates = new List<string>();

            foreach (var product in order.Products)
            {
                string newTemplate = template;

                newTemplate = newTemplate.Replace("{{{", "");
                newTemplate = newTemplate.Replace("}}}", "");
                newTemplate = newTemplate.Replace("{{cakeId}}", product.Product.Id.ToString());
                newTemplate = newTemplate.Replace("{{productName}}", product.Product.Name.ToString());
                newTemplate = newTemplate.Replace("{{productPrice}}", product.Product.Price.ToString());

                templates.Add(newTemplate);
            }

            content = content.Replace(template, string.Join("\r\n", templates));

            content = content.Replace("{{orderId}}", order.Id.ToString());
            content = content.Replace("{{createdOn}}", order.DateOfCreation.ToString());

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse ListOrders(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            var username = request.Cookies.GetCookie(".auth").Value;

            var user = context.Users.Include(x => x.Orders).ThenInclude(x => x.Products).ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Username == username);

            var content = File.ReadAllText(PathToViews + "ListOrders.html");

            int index = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            var template = content.Substring(index, endIndex - index + 3);

            List<string> templates = new List<string>();

            foreach (var order in user.Orders.OrderByDescending(x => x.DateOfCreation))
            {
                var newTemplate = template;

                newTemplate = newTemplate.Replace("{{{", "");
                newTemplate = newTemplate.Replace("}}}", "");
                newTemplate = newTemplate.Replace("{{orderDetailsId}}", order.Id.ToString());
                newTemplate = newTemplate.Replace("{{orderId}}", order.Id.ToString());
                newTemplate = newTemplate.Replace("{{createdOn}}", order.DateOfCreation.ToString());
                newTemplate = newTemplate.Replace("{{sum}}", order.Products.Sum(x => x.Product.Price).ToString());

                templates.Add(newTemplate);
            }

            content = content.Replace(template, string.Join("\r\n", templates));

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }

        public IHttpResponse Order(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            if (!request.Cookies.ContainsCookie("cart"))
            {
                return new HtmlResult("<h1>The cart is empty</h1>", HttpResponseStatusCode.BadRequest);
            }

            var username = request.Cookies.GetCookie(".auth").Value;

            var user = context.Users.FirstOrDefault(x => x.Username == username);

            var cart = request.Cookies.GetCookie("cart").Value;

            if (string.IsNullOrEmpty(cart) || string.IsNullOrWhiteSpace(cart))
            {
                return new HtmlResult("<h1>The cart is empty</h1>", HttpResponseStatusCode.BadRequest);
            }

            var cartElements = cart.Split(" ");

            var order = new Order
            {
                DateOfCreation = DateTime.UtcNow,
                UserId = user.Id
            };

            context.Orders.Add(order);

            context.SaveChanges();

            //var order = context.Orders.Last();

            foreach (var element in cartElements)
            {
                var elTokens = element.Split("=");

                var product = context.Products.FirstOrDefault(x => x.Name == elTokens[0]);

                context.OrderProducts.Add(new OrderProduct
                {
                    OrderId = order.Id,
                    ProductId = product.Id
                });
            }

            context.SaveChanges();

            var response = new RedirectResult("/");

            var cartCookie = request.Cookies.GetCookie("cart");
            cartCookie.Expire();

            response.Cookies.Add(cartCookie);

            return response;
        }

        public IHttpResponse Cart(IHttpRequest request)
        {
            if (!request.Cookies.ContainsCookie(".auth"))
            {
                return new RedirectResult("/");
            }

            if (!request.Cookies.ContainsCookie("cart"))
            {
                return new HtmlResult("<h1>The cart is empty</h1>", HttpResponseStatusCode.BadRequest);
            }

            var cart = request.Cookies.GetCookie("cart").Value;

            if (string.IsNullOrEmpty(cart) || string.IsNullOrWhiteSpace(cart))
            {
                return new HtmlResult("<h1>The cart is empty</h1>", HttpResponseStatusCode.BadRequest);
            }

            var cartElements = cart.Split(" ");

            var content = File.ReadAllText(PathToViews + "Cart.html");

            int index = content.IndexOf("{{{");
            int endIndex = content.IndexOf("}}}");

            var template = content.Substring(index, endIndex - index + 3);

            List<string> templates = new List<string>();

            decimal total = 0.0m;

            foreach (var element in cartElements)
            {
                var elementTokens = element.Split("=");

                string newTemplate = template;

                var cake = context.Products.FirstOrDefault(x => x.Name == elementTokens[0]);

                newTemplate = newTemplate.Replace("{{{", "");
                newTemplate = newTemplate.Replace("}}}", "");
                newTemplate = newTemplate.Replace("{{Name}}", elementTokens[0]);
                newTemplate = newTemplate.Replace("{{Quantity}}", elementTokens[1]);
                newTemplate = newTemplate.Replace("{{Price}}", cake.Price.ToString());
                newTemplate = newTemplate.Replace("{{TotalItem}}", (int.Parse(elementTokens[1]) * cake.Price).ToString());

                total += (int.Parse(elementTokens[1]) * cake.Price);

                templates.Add(newTemplate);
            }

            content = content.Replace(template, string.Join("\r\n", templates));
            content = content.Replace("{{Total}}", total.ToString());

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
