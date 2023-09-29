﻿using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using SIS.HTTP.Sessions;
using System.Collections.Generic;

namespace SIS.HTTP.Requests
{
    public interface IHttpRequest
    {
        string Path { get; }
        string URL { get; }

        Dictionary<string, object> FormData { get; }
        Dictionary<string, object> QueryData { get; }
        IHttpHeaderCollection Headers { get; }
        HttpRequestMethod RequestMethod { get; }
        IHttpCookieCollection Cookies { get; }
        IHttpSession Session { get; set; }
    }
}
