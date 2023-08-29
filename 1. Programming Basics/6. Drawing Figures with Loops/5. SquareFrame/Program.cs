using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number - 1)
                {
                    Console.Write("+ ");
                    for (int j = 0; j < number - 2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int j = 0; j < number - 2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }
        }
    }
}
