using System;

namespace MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}", SumOfOddNumbers(Math.Abs(number)) * SumOfEvenNumbers(Math.Abs(number)));
        }

        static long SumOfOddNumbers(long number)
        {
            long odd = 0;

            while (number > 0)
            {
                long digit = GetDigit(number);
                if (digit % 2 != 0)
                {
                    odd += digit;
                }
                number /= 10;
            }

            return odd;
        }

        static long SumOfEvenNumbers(long number)
        {
            long even = 0;

            while (number > 0)
            {
                long digit = GetDigit(number);
                if (digit % 2 == 0)
                {
                    even += digit;
                }
                number /= 10;
            }

            return even;
        }

        static long GetDigit(long number)
        {
            return number % 10;
        }
    }
}
