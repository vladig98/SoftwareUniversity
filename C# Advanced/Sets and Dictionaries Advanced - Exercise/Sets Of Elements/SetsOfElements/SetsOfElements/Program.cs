using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputTokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sizeOfFirstSet = inputTokens[0];
            int sizeOfSecondSet = inputTokens[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            for (int i = 0; i < sizeOfFirstSet; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            for (int i = 0; i < sizeOfSecondSet; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            duplicates = firstSet.Where(x => secondSet.Contains(x)).Select(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ", duplicates));
        }
    }
}
