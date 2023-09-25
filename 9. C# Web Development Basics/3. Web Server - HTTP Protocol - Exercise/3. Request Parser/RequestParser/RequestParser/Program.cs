using System;
using System.Collections.Generic;
using System.Linq;

namespace RequestParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> methods = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                string[] tokens = input.Split("/").ToArray();
                string method = tokens[tokens.Length - 1];

                string path = string.Join("/", tokens.Take(tokens.Length - 1));

                if (methods.ContainsKey(path.ToLower()))
                {
                    if (!methods[path.ToLower()].Contains(method.ToLower()))
                    {
                        methods[path.ToLower()].Add(method.ToLower());
                    }
                }
                else
                {
                    methods.Add(path.ToLower(), new List<string> { method.ToLower() });
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            string[] requestTokens = input.Split(" ").ToArray();
            string requestMethod = requestTokens[0];
            string requestPath = requestTokens[1];

            int statusCode = 200;

            if (!methods.ContainsKey(requestPath.ToLower()))
            {
                statusCode = 404;
            }
            else if (!methods[requestPath.ToLower()].Contains(requestMethod.ToLower()))
            {
                statusCode = 404;
            }

            string status = statusCode == 200 ? "OK" : "NotFound";

            Console.WriteLine($"HTTP/1.1 {statusCode} {status}\r\nContent-Length: {status.Length}\r\nContent-Type: text/plain\r\n\r\n{status}");
        }
    }
}
