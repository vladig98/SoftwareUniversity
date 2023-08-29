using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    int num = row + col + 1;
                    if (num > dimensions)
                    {
                        Console.Write(2 * dimensions - num + " ");
                    }
                    else
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
