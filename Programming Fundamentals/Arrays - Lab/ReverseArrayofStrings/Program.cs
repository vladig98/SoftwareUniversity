using System;
using System.Linq;

namespace ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters = Console.ReadLine().Split(" ").ToArray();

            for (int i = characters.Length - 1; i >= 0; i--)
            {
                Console.Write($"{characters[i]} ");
            }
        }
    }
}
