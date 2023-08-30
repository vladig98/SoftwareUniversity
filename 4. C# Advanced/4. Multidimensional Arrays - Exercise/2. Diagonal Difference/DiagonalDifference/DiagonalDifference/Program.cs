using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                int[] numbers = Console.ReadLine().Trim().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int i = 0; i < dimension; i++)
            {
                diagonal1 += matrix[i, i];
            }

            for (int i = 0; i < dimension; i++)
            {
                int j = dimension - i - 1;
                diagonal2 += matrix[i, j];
            }

            Console.WriteLine(Math.Abs(diagonal1 - diagonal2));
        }
    }
}
