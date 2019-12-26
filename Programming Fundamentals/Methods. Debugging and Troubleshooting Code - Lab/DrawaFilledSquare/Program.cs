using System;

namespace DrawaFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopAndBottom(number);
            for (int i = 0; i < number - 2; i++)
            {
                PrintMiddleRows(number);
            }
            PrintTopAndBottom(number);
        }

        static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddleRows(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
