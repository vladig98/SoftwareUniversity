using System.Linq;

namespace SIS.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string str)
            => str[0].ToString().ToUpper() + string.Join("", str.Skip(1).ToArray()).ToLower();
    }
}
