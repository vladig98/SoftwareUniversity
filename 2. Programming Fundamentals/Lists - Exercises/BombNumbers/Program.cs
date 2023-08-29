using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();
            int[] cmds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (numbers.Contains(cmds[0]))
            {
                int index = numbers.IndexOf(cmds[0]);

                int start = index - cmds[1] < 0 ? 0 : index - cmds[1];
                int end = index + cmds[1] >= numbers.Count ? numbers.Count - 1 : index + cmds[1];

                numbers.RemoveRange(start, end - start + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
