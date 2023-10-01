using SIS.WebServer.Api;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SIS.WebServer
{
    public class Server
    {
        private const string LocalhostIpAddress = "127.0.0.1";
        private readonly int port;
        private readonly TcpListener listener;
        private readonly IHttpHandler handler;
        private readonly IHttpHandler sourceHandler;
        private bool isRunning;

        public Server(int port, IHttpHandler handler, IHttpHandler sourceHandler)
        {
            this.port = port;
            listener = new TcpListener(IPAddress.Parse(LocalhostIpAddress), port);
            this.handler = handler;
            this.sourceHandler = sourceHandler;

        }

        public void Run()
        {
            listener.Start();
            isRunning = true;

            Console.WriteLine($"Server started at http://{LocalhostIpAddress}:{port}");

            var task = Task.Run(ListenLoop);
            task.Wait();
        }

        public async Task ListenLoop()
        {
            while (isRunning)
            {
                var client = await listener.AcceptSocketAsync();
                var connectionHandler = new ConnectionHandler(client, handler, sourceHandler);
                var responseTask = connectionHandler.ProcessRequestAsync();
                responseTask.Wait();
            }
        }
    }
}
