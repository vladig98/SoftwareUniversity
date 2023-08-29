using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
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
