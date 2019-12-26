using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList<double>();

            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (occurrences.ContainsKey(numbers.ElementAt(i)))
                {
                    occurrences[numbers.ElementAt(i)]++;
                }
                else
                {
                    occurrences.Add(numbers.ElementAt(i), 1);
                }
            }

            occurrences = occurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
