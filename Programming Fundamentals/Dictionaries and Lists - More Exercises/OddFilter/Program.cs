using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            numbers.RemoveAll(x => x % 2 != 0);
            numbers = numbers.Select(x => x > numbers.Average() ? x + 1 : x - 1).ToList<int>();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
