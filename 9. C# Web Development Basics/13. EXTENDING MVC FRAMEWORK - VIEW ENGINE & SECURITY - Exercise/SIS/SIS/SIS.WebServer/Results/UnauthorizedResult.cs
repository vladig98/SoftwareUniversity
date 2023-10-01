using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using SIS.HTTP.Responses;
using System.Text;

namespace SIS.WebServer.Results
{
    public class UnauthorizedResult : HttpResponse
    {
        private const string DefaultErrorHeading = "<h1>You have no permission to access this functionality.</h1>";

        public UnauthorizedResult() : base(HttpResponseStatusCode.Unauthorized)
        {
            Headers.Add(new HttpHeader("Content-Type", "text/html"));
            Content = Encoding.UTF8.GetBytes(DefaultErrorHeading);
        }
    }
}
