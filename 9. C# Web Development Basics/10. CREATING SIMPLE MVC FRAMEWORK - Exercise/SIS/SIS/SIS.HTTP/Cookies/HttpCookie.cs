using System;

namespace SIS.HTTP.Cookies
{
    public class HttpCookie
    {
        private const int HttpCookieDefaultExpirationDays = 3;

        public HttpCookie(string key, string value, int expires = HttpCookieDefaultExpirationDays)
        {
            Key = key;
            Value = value;
            IsNew = true;
            Expires = DateTime.UtcNow.AddDays(expires);
        }

        public HttpCookie(string key, string value, bool isNew, int expires = HttpCookieDefaultExpirationDays)
            : this(key, value, expires)
        {
            IsNew = isNew;
        }

        public string Key { get; }
        public string Value { get; }
        public DateTime Expires { get; private set; }
        public bool IsNew { get; private set; }

        public void Expire()
        {
            Expires = DateTime.UtcNow.AddDays(-10);
            IsNew = false;
        }

        public override string ToString()
        {
            return $"{Key}={Value}; Expires={Expires:R}; Path=/";
        }
    }
}
