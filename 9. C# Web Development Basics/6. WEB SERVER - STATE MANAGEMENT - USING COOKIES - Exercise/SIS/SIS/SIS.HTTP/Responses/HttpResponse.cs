using SIS.HTTP.Common;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Extensions;
using SIS.HTTP.Headers;
using System;
using System.Linq;
using System.Text;

namespace SIS.HTTP.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            
        }

        public HttpResponse(HttpResponseStatusCode statusCode)
        {
            Headers = new HttpHeaderCollection();
            Content = new byte[0];
            StatusCode = statusCode;
            Cookies = new HttpCookieCollection();
        }

        public HttpResponseStatusCode StatusCode { get; set; }

        public IHttpHeaderCollection Headers { get; private set; }

        public IHttpCookieCollection Cookies { get; private set; }

        public byte[] Content { get; set; }

        public void AddCookie(HttpCookie cookie)
        {
            if (!Cookies.ContainsCookie(cookie.Key))
            {
                Cookies.Add(cookie);
            }
        }

        public void AddHeader(HttpHeader header)
        {
            Headers.Add(header);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ToString());

            bytes = bytes.Concat(Content).ToArray();

            return bytes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{GlobalConstants.HttpOneProtocolFragment} {StatusCode.GetResponseLine()}");
            sb.Append(Environment.NewLine);
            sb.Append(Headers);
            sb.Append(Environment.NewLine);

            if (Cookies.HasCookies())
            {
                sb.Append($"Set-Cookie: {Cookies}").Append(Environment.NewLine);
            }

            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
