using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> squares = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squares.Add(numbers[i]);
                }
            }

            squares = squares.OrderByDescending(x => x).ToList<int>();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
