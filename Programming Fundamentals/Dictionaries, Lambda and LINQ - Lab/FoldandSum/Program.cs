using System;
using System.Linq;

namespace FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] part1 = numbers.Take(numbers.Length / 4).ToArray();
            int[] part2 = numbers.Skip(part1.Length + numbers.Length / 2).Take(numbers.Length / 4).ToArray();

            int[] middle = numbers.Skip(numbers.Length / 4).Take(numbers.Length / 2).ToArray();

            int[] results = new int[middle.Length];

            int[] top = part1.Reverse().ToArray().Concat(part2.Reverse().ToArray()).ToArray();

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = top[i] + middle[i];
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
