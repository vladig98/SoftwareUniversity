using System;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            int value = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();
                int index = 0;
                int limit = 0;
                int temp = 0;

                switch (tokens[1])
                {
                    case "up":
                        index = int.Parse(tokens[0]);
                        limit = int.Parse(tokens[2]) % matrix.GetLength(0);
                        for (int k = 0; k < limit; k++)
                        {
                            temp = matrix[0, index];
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                matrix[j, index] = matrix[(j + 1) % matrix.GetLength(0), index];
                                if (j == matrix.GetLength(0) - 1)
                                {
                                    matrix[j, index] = temp;
                                }
                            }
                        }
                        break;
                    case "down":
                        index = int.Parse(tokens[0]);
                        limit = int.Parse(tokens[2]) % matrix.GetLength(0);
                        for (int k = 0; k < limit; k++)
                        {
                            temp = matrix[matrix.GetLength(0) - 1, index];
                            for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                            {
                                matrix[j, index] = matrix[Math.Abs((j - 1)) % matrix.GetLength(0), index];
                                if (j == 0)
                                {
                                    matrix[j, index] = temp;
                                }
                            }
                        }
                        break;
                    case "left":
                        index = int.Parse(tokens[0]);
                        limit = int.Parse(tokens[2]) % matrix.GetLength(1);
                        for (int k = 0; k < limit; k++)
                        {
                            temp = matrix[index, 0];
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[index, j] = matrix[index, Math.Abs((j + 1)) % matrix.GetLength(1)];
                                if (j == matrix.GetLength(1) - 1)
                                {
                                    matrix[index, j] = temp;
                                }
                            }
                        }
                        break;
                    case "right":
                        index = int.Parse(tokens[0]);
                        limit = int.Parse(tokens[2]) % matrix.GetLength(1);
                        for (int k = 0; k < limit; k++)
                        {
                            temp = matrix[index, matrix.GetLength(1) - 1];
                            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                            {
                                matrix[index, j] = matrix[index, Math.Abs((j - 1)) % matrix.GetLength(1)];
                                if (j == 0)
                                {
                                    matrix[index, j] = temp;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            int currentValue = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == currentValue)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            for (int l = 0; l < matrix.GetLength(1); l++)
                            {
                                if (matrix[k, l] == currentValue)
                                {
                                    Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", i, j, k, l);
                                    int tempValue = matrix[i, j];
                                    matrix[i, j] = matrix[k, l];
                                    matrix[k, l] = tempValue;
                                }
                            }
                        }
                    }

                    currentValue++;
                }
            }
        }
    }
}
