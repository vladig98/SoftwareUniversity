using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(dimensions[0]);
            Console.WriteLine(dimensions[1]);
            Console.WriteLine(sum);
        }
    }
}
