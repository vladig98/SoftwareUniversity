using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] hideoutHints = Console.ReadLine().Split(" ").ToArray();

                if (Regex.IsMatch(input, @"\" + hideoutHints[0] + @"{" + hideoutHints[1] + @",}"))
                {
                    string match = Regex.Match(input, @"\" + hideoutHints[0] + @"{" + hideoutHints[1] + @",}").Value;
                    int index = input.IndexOf(match);

                    Console.WriteLine($"Hideout found at index {index} and it is with size {match.Length}!");

                    return;
                }
            }
        }
    }
}
