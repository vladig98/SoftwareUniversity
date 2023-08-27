using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int[][] matrix = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[i] = new int[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i][j] = input[j];
                }
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split(" ");

                switch (tokens[0])
                {
                    case "Add":
                        if (int.Parse(tokens[1]) < 0 || int.Parse(tokens[2]) < 0 || int.Parse(tokens[1]) >= matrix.Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }
                        if (int.Parse(tokens[2]) >= matrix[int.Parse(tokens[1])].Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }
                        matrix[int.Parse(tokens[1])][int.Parse(tokens[2])] += int.Parse(tokens[3]);
                        break;
                    case "Subtract":
                        if (int.Parse(tokens[1]) < 0 || int.Parse(tokens[2]) < 0 || int.Parse(tokens[1]) >= matrix.Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }
                        if (int.Parse(tokens[2]) >= matrix[int.Parse(tokens[1])].Length)
                        {
                            Console.WriteLine("Invalid coordinates");
                            break;
                        }
                        matrix[int.Parse(tokens[1])][int.Parse(tokens[2])] -= int.Parse(tokens[3]);
                        break;
                    default:
                        break;
                }

                inputLine = Console.ReadLine();
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
