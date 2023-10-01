using SIS.Demo.Controllers;
using SIS.Framework;
using SIS.Framework.Routers;
using SIS.HTTP.Enums;
using SIS.WebServer;
using SIS.WebServer.Api;
using SIS.WebServer.Routing;

namespace SIS.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            IHttpHandler handler = new ControllerRouter();

            //serverRoutingTable.Routes[HttpRequestMethod.Get]["/"] = request => new HomeController().Index();

            Server server = new Server(8000, handler);

            MvcEngine.Run(server);
        }
    }
}
