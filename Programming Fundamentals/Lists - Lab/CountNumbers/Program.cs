using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (occurrences.ContainsKey(numbers[i]))
                {
                    occurrences[numbers[i]]++;
                }
                else
                {
                    occurrences.Add(numbers[i], 1);
                }
            }

            occurrences = occurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
