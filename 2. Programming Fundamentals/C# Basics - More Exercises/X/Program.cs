using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int spaces = number - 2;
            int value = -2;

            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', spaces));
                spaces += value;
            }

            Console.WriteLine("{0}x{0}", new string(' ', number / 2));

            value = 2;

            for (int i = number / 2 - 1; i >= 0; i--)
            {
                spaces += value;
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', spaces));
            }
        }
    }
}
