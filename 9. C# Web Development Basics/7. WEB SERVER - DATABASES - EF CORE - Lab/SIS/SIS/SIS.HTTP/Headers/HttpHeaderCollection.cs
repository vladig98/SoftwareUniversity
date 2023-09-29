using System.Collections.Generic;

namespace SIS.HTTP.Headers
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            if (!headers.ContainsKey(header.Key))
            {
                headers.Add(header.Key, header);
            }
        }

        public bool ContainsHeader(string key)
            => headers.ContainsKey(key);

        public HttpHeader GetHeader(string key)
        {
            if (headers.ContainsKey(key))
            {
                return headers[key];
            }

            return null;
        }

        public override string ToString()
            => string.Join("\r\n", headers.Values);
    }
}
