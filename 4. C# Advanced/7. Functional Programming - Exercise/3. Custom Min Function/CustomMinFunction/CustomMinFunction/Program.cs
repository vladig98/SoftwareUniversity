﻿using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Func<int[], int> customMin = nums => nums.Min();

            Console.WriteLine(customMin(numbers));
        }
    }
}
