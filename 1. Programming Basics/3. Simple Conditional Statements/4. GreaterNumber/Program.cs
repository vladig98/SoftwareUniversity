﻿using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a, b));
        }
    }
}
