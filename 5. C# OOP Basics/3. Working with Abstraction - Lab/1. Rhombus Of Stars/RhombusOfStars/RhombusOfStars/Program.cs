using System;
using System.Linq;

namespace RhombusOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStars = int.Parse(Console.ReadLine());

            DrawRhombus(numberOfStars);
        }

        private static void DrawRhombus(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', numberOfStars - i), string.Join(" ", Enumerable.Repeat("*", i)));
            }

            for (int i = numberOfStars - 1; i >= 1; i--)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', numberOfStars - i), string.Join(" ", Enumerable.Repeat("*", i)));
            }
        }
    }
}
