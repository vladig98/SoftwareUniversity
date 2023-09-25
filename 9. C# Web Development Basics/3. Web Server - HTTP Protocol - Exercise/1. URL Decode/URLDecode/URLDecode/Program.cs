using System;
using System.Net;

namespace URLDecode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            string decodedURL = WebUtility.UrlDecode(url);

            Console.WriteLine(decodedURL);
        }
    }
}
