using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
