using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[3][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[] { };
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                List<int> temp = new List<int>();
                switch (Math.Abs(numbers[i]) % 3)
                {
                    case 0:
                        temp = matrix[0].ToList();
                        temp.Add(numbers[i]);
                        matrix[0] = temp.ToArray();
                        break;
                    case 1:
                        temp = matrix[1].ToList();
                        temp.Add(numbers[i]);
                        matrix[1] = temp.ToArray();
                        break;
                    case 2:
                        temp = matrix[2].ToList();
                        temp.Add(numbers[i]);
                        matrix[2] = temp.ToArray();
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
