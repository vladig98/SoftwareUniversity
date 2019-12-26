using System;
using System.Linq;

namespace GrabandGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            numbers = numbers.Reverse().Select(x => x).ToArray();

            int index = Array.IndexOf(numbers, number);

            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            long sum = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
