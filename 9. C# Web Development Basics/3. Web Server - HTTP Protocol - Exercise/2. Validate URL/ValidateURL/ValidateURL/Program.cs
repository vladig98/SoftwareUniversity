using System;
using System.Linq;
using System.Net;

namespace ValidateURL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string URL = Console.ReadLine();

            string decodedURL = WebUtility.UrlDecode(URL);

            string protocol = string.Empty;
            
            if (decodedURL.Split("://").Length == 2)
            {
                protocol = decodedURL.Split("://")[0];
                decodedURL = decodedURL.Split("://")[1];
            }
            else
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            if (protocol != "https" && protocol != "http" )
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var host = decodedURL.Split("/")[0].Split(":")[0];

            if (string.IsNullOrEmpty(host))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var port = string.Empty;

            if (decodedURL.Split("/")[0].Split(":").Length > 1)
            {
                port = decodedURL.Split("/")[0].Split(":")[1];
            }

            if (string.IsNullOrEmpty(port))
            {
                if (protocol == "http")
                {
                    port = "80";
                }
                else if (protocol == "https")
                {
                    port = "443";
                }
                else
                {
                    Console.WriteLine("Invalid URL");
                    return;
                }
            }

            if (port == "443" && protocol == "http")
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            if (port == "80" && protocol == "https")
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var path = "/";

            if (decodedURL.Split("?")[0].Split("/").Length > 1)
            {
                path += string.Join("/", decodedURL.Split("?")[0].Split("/").Skip(1));
            }

            var parameters = string.Empty;

            if (decodedURL.Split("?").Length > 1)
            {
                parameters = decodedURL.Split("?")[1].Split("#")[0];
            }

            var fragment = string.Empty;

            if (decodedURL.Split("#").Length > 1)
            {
                fragment = decodedURL.Split("#")[1];
            }

            Console.WriteLine($"Protocol: {protocol}\r\nHost: {host}\r\nPort: {port}\r\nPath: {path}" +
                $"\r\n" + (string.IsNullOrEmpty(parameters) ? null : $"Query: {parameters}\r\n") + 
                (string.IsNullOrEmpty(fragment) ? null : $"Fragment: {fragment}"));
        }
    }
}
