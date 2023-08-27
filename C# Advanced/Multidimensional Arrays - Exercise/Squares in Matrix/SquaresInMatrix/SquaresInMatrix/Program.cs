using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            int numberOfSquares = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] characters = Console.ReadLine().ToCharArray().Where(x => x != ' ').Select(x => x.ToString()).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = characters[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    string elementA = matrix[i, j];
                    string elementB = matrix[i, j + 1];
                    string elementC = matrix[i + 1, j];
                    string elementD = matrix[i + 1, j + 1];

                    if (elementA == elementB && elementA == elementC && elementA == elementD)
                    {
                        numberOfSquares++;
                    }
                }
            }

            Console.WriteLine(numberOfSquares);
        }
    }
}
