using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int biggestSum = 0;
            int[] square = new int[4];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > biggestSum)
                    {
                        square = new int[]
                        {
                            matrix[i, j],
                            matrix[i, j + 1],
                            matrix[i + 1, j],
                            matrix[i + 1, j + 1]
                        };
                        biggestSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    }
                }
            }

            Console.WriteLine($"{square[0]} {square[1]}");
            Console.WriteLine($"{square[2]} {square[3]}");
            Console.WriteLine(biggestSum);
        }
    }
}
