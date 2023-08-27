using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                numbers.Add(i);
            }

            string numberType = Console.ReadLine();

            Predicate<int> even = num => num % 2 == 0;
            Predicate<int> odd = num => num % 2 != 0;

            switch (numberType)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(odd)));
                    break;
                case "even":
                    Console.WriteLine(string.Join(" ", numbers.FindAll(even)));
                    break;
                default:
                    break;
            }
        }
    }
}
