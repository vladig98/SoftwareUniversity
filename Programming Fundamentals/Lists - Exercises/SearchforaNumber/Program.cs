using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchforaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            int[] cmds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            numbers = numbers.Take(cmds[0]).Select(x => x).ToList<int>();
            numbers.RemoveRange(0, cmds[1]);

            if (numbers.Contains(cmds[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
