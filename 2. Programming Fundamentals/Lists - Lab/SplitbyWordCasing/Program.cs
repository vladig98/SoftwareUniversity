using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitbyWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new[] 
            { 
                " ", ",", ";", ":", ".", "!", "(", ")", "\"", "\'", "\\", "/", "[", "]" 
            }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();

            lowerCase = words.Where(x => x.All(y => y >= 97 && y <= 122)).Select(x => x).ToList<string>();
            upperCase = words.Where(x => x.All(y => y >= 65 && y <= 90)).Select(x => x).ToList<string>();

            foreach (var item in lowerCase)
            {
                words.Remove(item);
            }

            foreach (var item in upperCase)
            {
                words.Remove(item);
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", words)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
