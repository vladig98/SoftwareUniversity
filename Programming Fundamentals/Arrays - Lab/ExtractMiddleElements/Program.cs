using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                for (int i = (numbers.Length / 2) - 1; i <= numbers.Length / 2; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else if (numbers.Length % 2 != 0)
            {
                for (int i = ((int)(numbers.Length / 2)) - 1; i <= ((int)(numbers.Length / 2)) + 1; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
