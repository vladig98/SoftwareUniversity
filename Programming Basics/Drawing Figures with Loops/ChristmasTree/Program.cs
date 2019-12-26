using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Console.Write(new string(' ', number - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.WriteLine(new string(' ', number - i));
            }
        }
    }
}
