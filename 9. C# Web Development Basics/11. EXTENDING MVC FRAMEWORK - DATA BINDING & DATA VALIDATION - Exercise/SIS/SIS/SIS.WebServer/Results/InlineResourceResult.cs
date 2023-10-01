using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using SIS.HTTP.Responses;

namespace SIS.WebServer.Results
{
    public class InlineResourceResult : HttpResponse
    {
        public InlineResourceResult(byte[] content, HttpResponseStatusCode responseStatusCode) : base(responseStatusCode)
        {
            Headers.Add(new HttpHeader("Content-Length", content.Length.ToString()));
            Headers.Add(new HttpHeader("Content-Disposition", "inline"));
            Content = content;
        }
    }
}
