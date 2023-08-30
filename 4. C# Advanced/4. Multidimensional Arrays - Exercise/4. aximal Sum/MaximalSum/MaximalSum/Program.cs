using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Trim().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int bestSum = 0;
            int[,] winningSquare = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int elementA = matrix[i, j];
                    int elementB = matrix[i, j + 1];
                    int elementC = matrix[i, j + 2];
                    int elementD = matrix[i + 1, j];
                    int elementE = matrix[i + 1, j + 1];
                    int elementF = matrix[i + 1, j + 2];
                    int elementG = matrix[i + 2, j];
                    int elementH = matrix[i + 2, j + 1];
                    int elementI = matrix[i + 2, j + 2];

                    int currentSum = elementA + elementB + elementC + elementD + elementE + elementF + elementG + elementH + elementI;

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        winningSquare[0, 0] = elementA;
                        winningSquare[0, 1] = elementB;
                        winningSquare[0, 2] = elementC;
                        winningSquare[1, 0] = elementD;
                        winningSquare[1, 1] = elementE;
                        winningSquare[1, 2] = elementF;
                        winningSquare[2, 0] = elementG;
                        winningSquare[2, 1] = elementH;
                        winningSquare[2, 2] = elementI;
                    }
                }
            }

            Console.WriteLine("Sum = " + bestSum);
            for (int i = 0; i < winningSquare.GetLength(0); i++)
            {
                for (int j = 0; j < winningSquare.GetLength(1); j++)
                {
                    Console.Write(winningSquare[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
