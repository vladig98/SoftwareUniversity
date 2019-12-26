using System;
using System.Collections.Generic;

namespace PrimesinGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", GetPrimeNumbersInRange(start, end)));
        }

        private static List<int> GetPrimeNumbersInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            int temp = (int)Math.Sqrt(number);

            for (int i = 2; i <= temp; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
