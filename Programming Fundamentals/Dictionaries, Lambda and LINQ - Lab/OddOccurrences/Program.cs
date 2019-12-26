using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();

            Dictionary<string, int> occurrances = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (occurrances.ContainsKey(words[i].ToLower()))
                {
                    occurrances[words[i].ToLower()]++;
                }
                else
                {
                    occurrances.Add(words[i].ToLower(), 1);
                }
            }

            occurrances = occurrances.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine(string.Join(", ", occurrances.Keys));
        }
    }
}
