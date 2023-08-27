using System;
using System.Collections.Generic;

namespace BubbleSortTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 
                3582, 9183, 3069, 6363, 4271, 4134, 8076, 2206, 5556, 5647,
                9537, 9010, 9881, 9389, 2302, 5012, 7687, 1010, 8406, 2413 };
            Bubble bubble = new Bubble(integers);

            Console.WriteLine(string.Join("\r\n", bubble.BubbleSort()));
        }
    }
}
