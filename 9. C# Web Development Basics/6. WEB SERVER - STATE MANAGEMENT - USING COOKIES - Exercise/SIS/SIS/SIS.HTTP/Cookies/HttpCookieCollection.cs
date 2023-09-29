using System.Collections.Generic;
using System.Linq;

namespace SIS.HTTP.Cookies
{
    public class HttpCookieCollection : IHttpCookieCollection
    {
        private readonly ICollection<HttpCookie> cookies;

        public HttpCookieCollection()
        {
            cookies = new List<HttpCookie>();
        }

        public void Add(HttpCookie cookie)
        {
            cookies.Add(cookie);
        }

        public bool ContainsCookie(string key)
            => cookies.Any(x => x.Key == key);

        public HttpCookie GetCookie(string key)
            => cookies.FirstOrDefault(x => x.Key == key);

        public bool HasCookies()
            => cookies.Any();

        public override string ToString()
        {
            return string.Join("; ", cookies);
        }
    }
}
