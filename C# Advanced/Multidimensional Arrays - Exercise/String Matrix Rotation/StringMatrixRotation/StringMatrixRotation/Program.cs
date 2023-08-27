using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string rotation = Console.ReadLine();

            string input = Console.ReadLine();

            List<string> words = new List<string>();

            while (input != "END")
            {
                words.Add(input);

                input = Console.ReadLine();
            }

            int longestWord = words.OrderByDescending(x => x.Length).First().Length;

            words = words.Select(x => x + new string(' ', longestWord - x.Length)).ToList();
            int index = 0;

            string[,] matrix = new string[words.Count, longestWord];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string word = words.ElementAt(index++);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = word[j].ToString();
                }
            }

            int degrees = int.Parse(rotation.Split(new[] { "Rotate(", ")" }, StringSplitOptions.RemoveEmptyEntries).ToArray()[0]);

            for (int i = 0; i <= 3 - (degrees / 90) % 4; i++)
            {
                matrix = RotateMatrixCounterClockwise(matrix);
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

        static string[,] RotateMatrixCounterClockwise(string[,] oldMatrix)
        {
            string[,] newMatrix = new string[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn, newRow = 0;
            for (int oldColumn = oldMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }
            return newMatrix;
        }
    }
}
