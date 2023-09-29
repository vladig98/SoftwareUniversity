using SIS.HTTP.Enums;
using SIS.WebServer.Routing;
using SIS.WebServer;
using IRunes.Controllers;
using IRunes.Data;
using System.Linq;

namespace IRunes
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            //Home
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/"] = request => new HomeController().Index(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Home/Index"] = request => new HomeController().Index(request);

            //Users
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Users/Login"] = request => new UsersController().Login(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/Users/Login"] = request => new UsersController().LoginPost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Users/Register"] = request => new UsersController().Register(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/Users/Register"] = request => new UsersController().RegisterPost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Users/Logout"] = request => new UsersController().Logout(request);

            //Albums
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Albums/All"] = request => new AlbumsController().All(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/Albums/Create"] = request => new AlbumsController().CreatePost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Albums/Create"] = request => new AlbumsController().Create(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Albums/Details"] = request =>new AlbumsController().Details(request);

            //Tracks
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Tracks/Create"] = request => new TracksController().Create(request);
            serverRoutingTable.Routes[HttpRequestMethod.Post]["/Tracks/Create"] = request => new TracksController().CreatePost(request);
            serverRoutingTable.Routes[HttpRequestMethod.Get]["/Tracks/Details"] = request => new TracksController().Details(request);

            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}
