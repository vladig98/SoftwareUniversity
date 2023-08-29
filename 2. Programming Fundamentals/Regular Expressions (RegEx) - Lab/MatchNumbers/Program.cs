using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(-)?\d+(\.\d+)?($|(?=\s))";

            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);

            Console.WriteLine(string.Join(" ", matches.Cast<Match>().Select(x => x.Value).ToArray()));
        }
    }
}
