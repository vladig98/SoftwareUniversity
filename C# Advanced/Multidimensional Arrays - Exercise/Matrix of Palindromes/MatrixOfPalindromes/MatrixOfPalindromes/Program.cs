using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = i; j < dimensions[1] + i; j++)
                {
                    Console.Write("{0}{1}{0} ", (char)(i + 97), (char)(j + 97));
                }
                Console.WriteLine();
            }
        }
    }
}
