using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"(?<!\S)[A-Za-z0-9]+([-._]*[A-Za-z0-9]+)*@[A-Za-z]+([-]*[A-Za-z]+)*\.[A-Za-z]+([-]*[A-Za-z]+)*(\.[A-Za-z]+([-]*[A-Za-z]+)*)*";

            foreach (var word in words)
            {
                if (Regex.IsMatch(word.Trim(), pattern))
                {
                    Console.WriteLine(Regex.Match(word.Trim(), pattern).Value);
                }
            }
        }
    }
}
