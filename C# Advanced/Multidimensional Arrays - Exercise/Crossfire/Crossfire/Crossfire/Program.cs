using System;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[][] matrix = new int[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[dimensions[1]];
            }

            int index = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = index++;
                }
            }

            string input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                int[] tokens = input.Split(" ").Select(int.Parse).ToArray();

                int i = tokens[0];
                int j = tokens[1];

                for (int k = j; k <= j + tokens[2]; k++)
                {
                    if (i < matrix.Length && i >= 0)
                    {
                        if (k < matrix[i].Length && k >= 0)
                        {
                            matrix[i][k] = 0;
                        }
                    }
                }

                for (int k = i; k <= i + tokens[2]; k++)
                {
                    if (k < matrix.Length && k >= 0)
                    {
                        if (j < matrix[k].Length && j >= 0)
                        {
                            matrix[k][j] = 0;
                        }
                    }
                }

                for (int k = j; k >= j - tokens[2]; k--)
                {
                    if (i < matrix.Length && i >= 0)
                    {
                        if (k < matrix[i].Length && k >= 0)
                        {
                            matrix[i][k] = 0;
                        }
                    }
                }

                for (int k = i; k >= i - tokens[2]; k--)
                {
                    if (k < matrix.Length && k >= 0)
                    {
                        if (j < matrix[k].Length && j >= 0)
                        {
                            matrix[k][j] = 0;
                        }
                    }
                }

                for (int k = 0; k < matrix.Length; k++)
                {
                    matrix[k] = matrix[k].Where(x => x != 0).ToArray();
                }

                for (int k = 0; k < matrix.Length; k++)
                {
                    if (matrix[k].Length == 0)
                    {
                        matrix = RemoveRow(matrix, k);
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Length != 0)
                {
                    Console.WriteLine(string.Join(" ", matrix[i]));
                }
            }
        }

        public static T[] RemoveRow<T>(T[] array, int row)
        {
            T[] array2 = new T[array.Length - 1];

            Array.Copy(array, 0, array2, 0, row);
            Array.Copy(array, row + 1, array2, row, array2.Length - row);

            return array2;
        }
    }
}
