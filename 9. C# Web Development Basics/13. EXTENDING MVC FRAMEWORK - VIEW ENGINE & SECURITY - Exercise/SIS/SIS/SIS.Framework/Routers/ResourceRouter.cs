using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Api;
using SIS.WebServer.Results;
using System.IO;

namespace SIS.Framework.Routers
{
    public class ResourceRouter : IHttpHandler
    {
        public IHttpResponse Handle(IHttpRequest request)
        {
            string path = request.Path;

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
