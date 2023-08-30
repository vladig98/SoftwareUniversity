using System;
using System.Linq;

namespace FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] part1 = new int[numbers.Length / 2];
            int[] sum = new int[numbers.Length / 2];

            int part = numbers.Length / 4;
            int[] p1 = new int[part];
            int[] p2 = new int[part];
            int[] p3 = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                p1[i] = numbers[i];
            }

            for (int i = numbers.Length / 4; i < numbers.Length - numbers.Length / 4; i++)
            {
                p3[i - numbers.Length / 4] = numbers[i];
            }

            for (int i = numbers.Length - (numbers.Length / 4); i < numbers.Length; i++)
            {
                p2[i - (numbers.Length - (numbers.Length / 4))] = numbers[i];
            }

            p1 = p1.Reverse().ToArray();
            p2 = p2.Reverse().ToArray();

            for (int i = 0; i < p1.Length; i++)
            {
                part1[i] = p1[i];
            }

            for (int i = p2.Length; i < part1.Length; i++)
            {
                part1[i] = p2[i - p2.Length];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = part1[i] + p3[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
