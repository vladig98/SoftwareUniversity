using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(number));
        }

        private static int Fib(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number == 1)
            {
                return 1;
            }

            return Fib(number - 1) + Fib(number - 2);
        }
    }
}
