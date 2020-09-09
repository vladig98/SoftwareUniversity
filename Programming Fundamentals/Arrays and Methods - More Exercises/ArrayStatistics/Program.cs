using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(new[] { " ", "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            Console.WriteLine($"Min = {FindMinNumberOfArray(numbers)}");
            Console.WriteLine($"Max = {FindMaxNumberOfArray(numbers)}");
            Console.WriteLine($"Sum = {SumOfNumbersInArray(numbers)}");
            Console.WriteLine("Average = {0:0.############}", FindAverageOfArrayNumbers(numbers));
        }

        public static long FindMinNumberOfArray(long[] numbers)
        {
            long minNumber = long.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        public static long FindMaxNumberOfArray(long[] numbers)
        {
            long maxNumber = long.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        public static long SumOfNumbersInArray(long[] numbers)
        {
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static double FindAverageOfArrayNumbers(long[] numbers)
        {
            double average = 0;

            average = (double) SumOfNumbersInArray(numbers) / numbers.Length;

            return average;
        }
    }
}
