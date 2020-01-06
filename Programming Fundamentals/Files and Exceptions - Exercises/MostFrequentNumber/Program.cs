using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            string[] input = File.ReadAllLines(path + "input.txt");
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            List<int> results = new List<int>();


            for (int i = 0; i < input.Length; i++)
            {
                int[] numbers = input[i].Split(" ").Select(int.Parse).ToArray();
                occurrences = new Dictionary<int, int>();
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (occurrences.ContainsKey(numbers[j]))
                    {
                        occurrences[numbers[j]]++;
                    }
                    else
                    {
                        occurrences.Add(numbers[j], 1);
                    }
                }

                results.Add(occurrences.OrderByDescending(x => x.Value).First().Key);
            }

            File.WriteAllLines(path + "output.txt", results.Select(x => x.ToString()));
        }
    }
}
