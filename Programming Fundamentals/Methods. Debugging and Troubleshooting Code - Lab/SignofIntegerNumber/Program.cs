using System;

namespace SignofIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSignOfNumber(int.Parse(Console.ReadLine()));
        }

        static void PrintSignOfNumber (int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
