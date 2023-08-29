using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            CountTrailingZeros(number);
        }

        private static void CountTrailingZeros(int number)
        {
            int count = 0;

            BigInteger factorial = Factorial(number);

            string factorialToText = factorial.ToString();

            for (int i = factorialToText.Length - 1; i >= 0; i--)
            {
                if (factorialToText[i] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
