using System;
using System.Text.RegularExpressions;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string search = Console.ReadLine();

            int occurrances = Regex.Matches(input.ToLower(), search.ToLower()).Count;

            Console.WriteLine(occurrances);
        }
    }
}
