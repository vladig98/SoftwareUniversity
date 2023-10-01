using SIS.HTTP.Enums;
using System.Text.RegularExpressions;

namespace SIS.HTTP.Extensions
{
    public static class HttpResponseStatusExtensions
    {
        public static string GetResponseLine(this HttpResponseStatusCode statusCode)
            => $"{(int)(statusCode)} {Regex.Replace(statusCode.ToString(), "([a-z])([A-Z])", "$1 $2")}";
    }
}
