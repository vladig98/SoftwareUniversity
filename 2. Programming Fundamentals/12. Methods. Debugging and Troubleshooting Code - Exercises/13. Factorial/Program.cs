using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Factorial(number);
        }

        private static void Factorial(int number)
        {
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
