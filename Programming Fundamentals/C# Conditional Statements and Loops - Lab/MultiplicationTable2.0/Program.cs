using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int beginning = int.Parse(Console.ReadLine());

            if (beginning > 10)
            {
                Console.WriteLine($"{number} X {beginning} = {number * beginning}");
                return;
            }

            for (int i = beginning; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
