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
        public DateTime Expires { get; }
        public bool IsNew { get; }

        public override string ToString()
            => $"{Key}={Value}; Expires={Expires.ToLongTimeString()}";
    }
}
