using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong fibonacciNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(fibonacciNumber));
        }

        private static ulong GetFibonacci(ulong fibonacciNumber)
        {
            if (fibonacciNumber == 2 || fibonacciNumber == 1)
            {
                return 1;
            }

            return GetFibonacci(fibonacciNumber - 1) + GetFibonacci(fibonacciNumber - 2);
        }
    }
}
