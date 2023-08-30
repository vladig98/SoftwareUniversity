using System;
using System.Linq;

namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string input = Console.ReadLine();

            int newX = -1;
            int newY = -1;
            int dist = int.MaxValue;

            while (input != "stop")
            {
                int[] tokens = input.Split(" ").Select(int.Parse).ToArray();

                int z = tokens[0];
                int x = tokens[1];
                int y = tokens[2];
                newX = -1;
                newY = -1;
                dist = int.MaxValue;

                if (matrix[x, y] == 0)
                {
                    matrix[x, y] = 1;
                    Console.WriteLine(Math.Abs(x - z) + 1 + y);
                }
                else
                {
                    for (int i = y - 1; i > 0; i--)
                    {
                        if (matrix[x, i] == 0 && y - i < dist)
                        {
                            dist = y - i;
                            newX = x;
                            newY = i;
                        }
                    }

                    for (int i = y + 1; i < matrix.GetLength(1); i++)
                    {
                        if (matrix[x, i] == 0 && i - y < dist)
                        {
                            dist = i - y;
                            newX = x;
                            newY = i;
                        }
                    }

                    if (newX == -1 && newY == -1)
                    {
                        Console.WriteLine("Row {0} full", x);
                    }
                    else
                    {
                        matrix[newX, newY] = 1;
                        Console.WriteLine(Math.Abs(x - z) + 1 + newY);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
