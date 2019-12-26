using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList<double>();

            int temp = numbers.Count;

            while (true)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers.ElementAt(i) == numbers.ElementAt(i + 1))
                    {
                        numbers[i] = numbers.ElementAt(i) + numbers.ElementAt(i + 1);
                        numbers.RemoveAt(i + 1);
                    }
                }

                if (numbers.Count == temp)
                {
                    break;
                }

                temp = numbers.Count;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
