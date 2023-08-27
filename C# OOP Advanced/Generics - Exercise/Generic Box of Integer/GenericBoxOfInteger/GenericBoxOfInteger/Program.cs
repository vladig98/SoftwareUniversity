﻿using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIntegers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                GenericBox<int> box = new GenericBox<int>(number);
                Console.WriteLine(box);
            }
        }
    }
}
