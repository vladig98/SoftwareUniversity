using System;
using System.Linq;

namespace CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int offset = 0;

            while (offset != numbers.Length - 1)
            {
                for (int i = 0; i < numbers.Length - 1 - offset; i++)
                {
                    numbers[i] += numbers[i + 1];

                    if (i == numbers.Length - 2 - offset)
                    {
                        numbers[i + 1] = 0;
                    }
                }

                offset++;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
