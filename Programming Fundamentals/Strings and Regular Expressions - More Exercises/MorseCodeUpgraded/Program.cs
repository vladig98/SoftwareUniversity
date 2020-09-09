using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] partsOfSecretMessage = Console.ReadLine().Split("|").ToArray();

            string result = string.Empty;

            for (int i = 0; i < partsOfSecretMessage.Length; i++)
            {
                string part = partsOfSecretMessage[i];

                int total = 0;

                total += Regex.Matches(part, @"0").Count * 3;
                total += Regex.Matches(part, @"1").Count * 5;
                total += Regex.Matches(part, @"0{2,}").Select(x => x.Value.Length).Sum(x => x);
                total += Regex.Matches(part, @"1{2,}").Select(x => x.Value.Length).Sum(x => x);

                result += (char)total;
            }

            Console.WriteLine(result);
        }
    }
}
