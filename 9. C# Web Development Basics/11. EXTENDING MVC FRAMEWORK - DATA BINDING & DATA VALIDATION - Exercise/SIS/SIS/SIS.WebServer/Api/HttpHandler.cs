using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Routing;

namespace SIS.WebServer.Api
{
    public class HttpHandler : IHttpHandler
    {
        private readonly ServerRoutingTable serverRoutingTable;

        public HttpHandler(ServerRoutingTable serverRoutingTable)
        {
            this.serverRoutingTable = serverRoutingTable;
        }

        public IHttpResponse Handle(IHttpRequest httpRequest)
        {
            //if (!serverRoutingTable.Routes.ContainsKey(httpRequest.RequestMethod)
            //    || !serverRoutingTable.Routes[httpRequest.RequestMethod].ContainsKey(httpRequest.Path))
            //{
            //    return ReturnIfResource(httpRequest.Path);
            //}

            return serverRoutingTable.Routes[httpRequest.RequestMethod][httpRequest.Path].Invoke(httpRequest);
        }
    }
}
