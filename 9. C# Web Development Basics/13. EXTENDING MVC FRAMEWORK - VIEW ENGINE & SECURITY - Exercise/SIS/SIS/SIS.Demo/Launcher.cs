using SIS.Framework;

namespace SIS.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            //IDependencyContainer dependencyContainer = new DependencyContainer();

            //ServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            //IHttpHandler handler = new ControllerRouter(dependencyContainer);
            //IHttpHandler sourceHandler = new ResourceRouter();

            ////serverRoutingTable.Routes[HttpRequestMethod.Get]["/"] = request => new HomeController().Index();

            //Server server = new Server(8000, handler, sourceHandler);

            //MvcEngine.Run(server);

            WebHost.Start(new StartUp());
        }
    }
}
