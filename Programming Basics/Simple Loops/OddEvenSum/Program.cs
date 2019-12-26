using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += int.Parse(Console.ReadLine());
                }
                else
                {
                    sumOdd += int.Parse(Console.ReadLine());
                }
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd - sumEven)}");
            }
        }
    }
}
