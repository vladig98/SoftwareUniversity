using System;

namespace RhombusofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write(new string(' ', number - i - 1));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
            for (int i = number - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', number - i));
                for (int j = i - 1; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
