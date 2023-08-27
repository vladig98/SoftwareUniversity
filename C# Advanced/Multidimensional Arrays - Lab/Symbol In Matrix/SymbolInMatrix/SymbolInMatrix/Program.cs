using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            string[,] matrix = new string[dimensions, dimensions];

            for (int i = 0; i < dimensions; i++)
            {
                string[] row = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();
                for (int j = 0; j < dimensions; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            string symbol = Console.ReadLine();

            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
