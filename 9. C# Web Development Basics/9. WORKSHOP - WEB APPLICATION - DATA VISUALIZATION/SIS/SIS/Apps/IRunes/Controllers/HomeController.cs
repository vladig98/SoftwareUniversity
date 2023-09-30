using IRunes.Services;
using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;
using System.IO;

namespace IRunes.Controllers
{
    public class HomeController
    {
        private const string PathToViews = "../../../Views/";

        public IHttpResponse Index(IHttpRequest request)
        {
            string content = string.Empty;

            if (request.Cookies.ContainsCookie(".auth"))
            {
                content = File.ReadAllText(PathToViews + "LoggedInIndex.html");

                var username = request.Cookies.GetCookie(".auth").Value;

                username = EncryptionService.Decode(username);

                content = content.Replace("{{name}}", username);
            }
            else
            {
                content = File.ReadAllText(PathToViews + "Index.html");
            }

            return new HtmlResult(content, HttpResponseStatusCode.Ok);
        }
    }
}
