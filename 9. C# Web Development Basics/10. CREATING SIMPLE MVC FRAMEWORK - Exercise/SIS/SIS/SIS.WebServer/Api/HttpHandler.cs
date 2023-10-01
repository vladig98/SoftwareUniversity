using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using SIS.WebServer.Routing;
using System.IO;

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
            if (!serverRoutingTable.Routes.ContainsKey(httpRequest.RequestMethod)
                || !serverRoutingTable.Routes[httpRequest.RequestMethod].ContainsKey(httpRequest.Path))
            {
                return ReturnIfResource(httpRequest.Path);
            }

            return serverRoutingTable.Routes[httpRequest.RequestMethod][httpRequest.Path].Invoke(httpRequest);
        }

        private IHttpResponse ReturnIfResource(string path)
        {
            if (!path.Contains("."))
            {
                return new HttpResponse(HttpResponseStatusCode.NotFound);
            }

            int extensionIndex = path.LastIndexOf(".");
            int nameIndex = path.LastIndexOf("/");

            string pathExtenstion = path.Substring(extensionIndex + 1);
            string resourceName = path.Substring(nameIndex);

            string resourcePath = $"../../../Resources/{pathExtenstion}{resourceName}";

            if (!File.Exists(resourcePath))
            {
                return new HttpResponse(HttpResponseStatusCode.NotFound);
            }

            var content = File.ReadAllBytes(resourcePath);

            return new InlineResourceResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
