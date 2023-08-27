using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (occurrences.ContainsKey(chars[i]))
                {
                    occurrences[chars[i]]++;
                }
                else
                {
                    occurrences.Add(chars[i], 1);
                }
            }

            occurrences = occurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var occurrence in occurrences)
            {
                Console.WriteLine($"{occurrence.Key}: {occurrence.Value} time/s");
            }
        }
    }
}
