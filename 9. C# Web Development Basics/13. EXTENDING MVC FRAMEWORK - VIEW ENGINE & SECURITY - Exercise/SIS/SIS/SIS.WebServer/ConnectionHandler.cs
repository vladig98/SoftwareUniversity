using SIS.HTTP.Cookies;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.HTTP.Sessions;
using SIS.WebServer.Api;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SIS.WebServer
{
    public class ConnectionHandler
    {
        private readonly Socket client;
        private readonly IHttpHandler handler;
        private readonly IHttpHandler resourceHandler;

        public ConnectionHandler(Socket client, IHttpHandler handler, IHttpHandler resourceHandler)
        {
            this.client = client;
            this.handler = handler;
            this.resourceHandler = resourceHandler;

        }

        private string SetRequestSession(IHttpRequest request)
        {
            string sessionId = null;

            if (request.Cookies.ContainsCookie(HttpSessionStorage.SessionCookieKey))
            {
                var cookie = request.Cookies.GetCookie(HttpSessionStorage.SessionCookieKey);
                sessionId = cookie.Value;
                request.Session = HttpSessionStorage.GetSession(sessionId);
            }
            else
            {
                sessionId = Guid.NewGuid().ToString();
                request.Session = HttpSessionStorage.GetSession(sessionId);
            }

            return sessionId;
        }

        private void SetResponseSession(IHttpResponse response, string sessionId)
        {
            if (sessionId != null)
            {
                response.AddCookie(new HttpCookie(HttpSessionStorage.SessionCookieKey, $"{sessionId};HttpOnly=true"));
            }
        }

        private async Task<IHttpRequest> ReadRequest()
        {
            var result = new StringBuilder();
            var data = new ArraySegment<byte>(new byte[1024]);

            while (true)
            {
                int numberOfBytesRead = await client.ReceiveAsync(data.Array, SocketFlags.None);

                if (numberOfBytesRead == 0)
                {
                    break;
                }

                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numberOfBytesRead);
                result.Append(bytesAsString);

                if (numberOfBytesRead < 1023)
                {
                    break;
                }
            }

            if (result.Length == 0)
            {
                return null;
            }

            return new HttpRequest(result.ToString());
        }

        private async Task PrepareResponse(IHttpResponse httpResponse)
        {
            byte[] bytesSegment = httpResponse.GetBytes();

            await client.SendAsync(bytesSegment, SocketFlags.None);
        }

        public async Task ProcessRequestAsync()
        {
            var httpRequest = await ReadRequest();

            if (httpRequest != null)
            {
                var sessionId = SetRequestSession(httpRequest);

                IHttpResponse httpResponse = null;

                if (httpRequest.Path.Contains("."))
                {
                    httpResponse = resourceHandler.Handle(httpRequest);
                }
                else
                {
                    httpResponse = handler.Handle(httpRequest);
                }

                SetResponseSession(httpResponse, sessionId);

                await PrepareResponse(httpResponse);
            }

            client.Shutdown(SocketShutdown.Both);
        }
    }
}
