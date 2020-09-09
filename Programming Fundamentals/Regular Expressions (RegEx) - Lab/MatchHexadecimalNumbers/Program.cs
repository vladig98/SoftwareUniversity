using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[\dA-F]+\b";

            string input = Console.ReadLine();

            string[] numbers = Regex.Matches(input, pattern).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
