using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Exceptions;
using SIS.HTTP.Headers;
using SIS.HTTP.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIS.HTTP.Requests
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            FormData = new Dictionary<string, object>();
            QueryData = new Dictionary<string, object>();
            Headers = new HttpHeaderCollection();
            Cookies = new HttpCookieCollection();

            ParseRequest(requestString);
        }

        private void ParseRequest(string requestString)
        {
            string[] splitRequestContent = requestString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            string[] requestLine = splitRequestContent[0].Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (!IsValidRequestLive(requestLine))
            {
                throw new BadRequestException();
            }

            ParseRequestMethod(requestLine);
            ParseRequestUrl(requestLine);
            ParseRequestPath();

            ParseHeaders(splitRequestContent.Skip(1).ToArray());
            ParseCookies();

            ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
        }

        private void ParseCookies()
        {
            if (Headers.ContainsHeader("Cookie"))
            {
                var header = Headers.GetHeader("Cookie");
                var cookieParams = header.Value.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < cookieParams.Length; i++)
                {
                    var cookieTokens = cookieParams[i].Split('=');
                    var cookie = new HttpCookie(cookieTokens[0], string.Join("=", cookieTokens.Skip(1)));
                    Cookies.Add(cookie);
                }
            }
        }

        private void ParseRequestParameters(string requestBody)
        {
            ParseQueryParameters();
            ParseFormDataParameters(requestBody);
        }

        private void ParseFormDataParameters(string requestBody)
        {
            if (string.IsNullOrEmpty(requestBody) || string.IsNullOrWhiteSpace(requestBody))
            {
                return;
            }

            string[] parameterPairs = requestBody.Split("&");

            foreach (string parameterPair in parameterPairs)
            {
                string[] keyValue = parameterPair.Split("=");

                if (!FormData.ContainsKey(keyValue[0]))
                {
                    FormData.Add(keyValue[0], keyValue[1]);
                }
            }
        }

        private void ParseQueryParameters()
        {
            string query = URL.Split("?").Length == 2 ? URL.Split("?")[1].Split("#")[0] : null;

            if (query == null)
            {
                return;
            }

            IsValidrequestQueryString(query);

            string[] queryPairs = query.Split("&");

            foreach (string pair in queryPairs)
            {
                string[] keyValue = pair.Split("=");

                if (!QueryData.ContainsKey(keyValue[0]))
                {
                    QueryData.Add(keyValue[0], keyValue[1]);
                }
            }
        }

        private void IsValidrequestQueryString(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
            {
                throw new BadRequestException();
            }
        }

        private void ParseHeaders(string[] requestContent)
        {
            foreach (string header in requestContent)
            {
                if (!string.IsNullOrEmpty(header) && !string.IsNullOrWhiteSpace(header))
                {
                    if (header.Split(": ").Length > 1)
                    {
                        string[] headerTokens = header.Split(": ").Select(x => x.Trim()).ToArray();

                        HttpHeader headerToInsert = new HttpHeader(headerTokens[0], string.Join(": ", headerTokens.Skip(1)));

                        Headers.Add(headerToInsert);
                    }
                }
            }

            if (!Headers.ContainsHeader("Host"))
            {
                throw new BadRequestException();
            }
        }

        private void ParseRequestPath()
        {
            string path = URL.Split("?")[0];
            Path = path;
        }

        private void ParseRequestUrl(string[] requestLine)
        {
            URL = requestLine[1];
        }

        private void ParseRequestMethod(string[] requestLine)
        {
            RequestMethod = (HttpRequestMethod)Enum.Parse(typeof(HttpRequestMethod), requestLine[0], true);
        }

        private bool IsValidRequestLive(string[] requestLine)
        {
            if (requestLine.Length == 3 && requestLine[2].ToUpper() == "HTTP/1.1")
            {
                return true;
            }

            return false;
        }

        public string Path { get; private set; }

        public string URL { get; private set; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public HttpRequestMethod RequestMethod { get; private set; }
        public IHttpCookieCollection Cookies { get; private set; }
        public IHttpSession Session { get; set; }
    }
}
