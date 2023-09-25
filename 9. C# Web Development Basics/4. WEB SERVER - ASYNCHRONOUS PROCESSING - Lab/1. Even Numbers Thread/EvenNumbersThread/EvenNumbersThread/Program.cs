using System;
using System.Threading;

namespace EvenNumbersThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            int num1 = int.Parse(inputTokens[0]);
            int num2 = int.Parse(inputTokens[1]);

            Thread evens = new Thread(() => PrintEvenNumbers(num1, num2));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumbers(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
