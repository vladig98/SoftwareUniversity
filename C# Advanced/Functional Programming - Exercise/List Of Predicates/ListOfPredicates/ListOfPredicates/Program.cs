using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int[] numbersToDivide = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            for (int i = 0; i < numbersToDivide.Length; i++)
            {
                int divideBy = numbersToDivide[i];

                predicates.Add(c => c % divideBy == 0);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => predicates.All(p => p(x)))));
        }
    }
}
