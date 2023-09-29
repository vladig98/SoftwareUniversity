using ByTheCake.Controllers;
using ByTheCake.Data;
using SIS.HTTP.Enums;
using SIS.WebServer;
using SIS.WebServer.Routing;
using System.Linq;

namespace ByTheCake
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            ByTheCakeDbContext context = new ByTheCakeDbContext();

            var cakes = context.Products.ToArray();
            var orders = context.Orders.ToArray();

            serverRoutingTable.Routes[HttpRequestMethod.Get]["/"] = request => new HomeController().Index(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/register"] = request => new UsersController().Register(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/register"] = request => new UsersController().RegisterUser(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/logout"] = request => new UsersController().Logout(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/login"] = request => new UsersController().Login(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/login"] = request => new UsersController().LoginPost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/profile"] = request => new UsersController().Profile(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/add"] = request => new CakesController().Add(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/add"] = request => new CakesController().AddCake(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/search"] = request => new CakesController().Search(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/search"] = request => new CakesController().SearchPost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/cart"] = request => new OrderController().Cart(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/order"] = request => new OrderController().Order(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/orders"] = request => new OrderController().ListOrders(request);
            
            foreach (var cake in cakes)
            {
                serverRoutingTable.Routes[HttpRequestMethod.Get]["/cakeDetails/" + cake.Id] = request => new CakesController().ShowCake(request);
                serverRoutingTable.Routes[HttpRequestMethod.Get]["/order/" + cake.Id] = request => new CakesController().Order(request);
            }

            foreach (var order in orders)
            {
                serverRoutingTable.Routes[HttpRequestMethod.Get]["/orderDetails/" + order.Id] = request => new OrderController().OrderDetails(request);
            }

            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}
