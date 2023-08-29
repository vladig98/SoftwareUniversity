using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int digit = (int)((Math.Abs(numbers[i]) * 10) % 10);
                if (numbers[i] >= 0)
                {
                    if (digit >= 5)
                    {
                        Console.WriteLine($"{numbers[i]} => {Math.Ceiling(numbers[i])}");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} => {Math.Floor(numbers[i])}");
                    }
                }
                else
                {
                    if (digit < 5)
                    {
                        Console.WriteLine($"{numbers[i]} => {Math.Ceiling(numbers[i])}");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} => {Math.Floor(numbers[i])}");
                    }
                }
            }
        }
    }
}
