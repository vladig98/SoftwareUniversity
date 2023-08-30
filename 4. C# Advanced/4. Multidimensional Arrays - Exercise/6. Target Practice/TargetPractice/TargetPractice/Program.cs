using System;
using System.Linq;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            string input = Console.ReadLine();

            int index = 0;
            int counter = 0;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                if (counter % 2 == 0)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[i, j] = input[index % input.Length].ToString();
                        index++;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = input[index % input.Length].ToString();
                        index++;
                    }
                }

                counter++;
            }

            int[] gunShot = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int x = gunShot[0];
                    int y = gunShot[1];
                    int r = gunShot[2];

                    double d = Math.Sqrt(Math.Pow(Math.Abs(i - x), 2) + Math.Pow(Math.Abs(j - y), 2));

                    if (d <= r)
                    {
                        matrix[i, j] = " ";
                    }
                }
            }

            bool moved = true;

            while (moved == true)
            {
                moved = false;

                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i + 1, j] == " " && matrix[i, j] != " ")
                        {
                            matrix[i + 1, j] = matrix[i, j];
                            matrix[i, j] = " ";
                            moved = true;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
