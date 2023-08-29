using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            Console.WriteLine(numbers.Select(x => int.Parse(string.Join("", x.ToString().Reverse()))).Sum());
        }
    }
}
