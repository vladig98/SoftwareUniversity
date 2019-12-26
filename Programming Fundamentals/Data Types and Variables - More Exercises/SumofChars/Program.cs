using System;

namespace SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                total += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
