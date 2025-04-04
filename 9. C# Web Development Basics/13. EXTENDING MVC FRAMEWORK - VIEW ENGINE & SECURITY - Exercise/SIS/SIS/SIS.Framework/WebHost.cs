﻿using SIS.Framework.Api;
using SIS.Framework.Routers;
using SIS.Framework.Services;
using SIS.WebServer;
using SIS.WebServer.Api;

namespace SIS.Framework
{
    public static class WebHost
    {
        private const int HostingPort = 8000;

        public static void Start(IMvcApplication application)
        {
            IDependencyContainer container = new DependencyContainer();
            application.ConfigureServices(container);

            IHttpHandler controllerRouter = new ControllerRouter(container);
            IHttpHandler sourceRouter = new ResourceRouter();

            application.Configure();

            Server server = new Server(HostingPort, controllerRouter, sourceRouter);
            MvcEngine.Run(server);
        }
    }
}
