using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(number1, number2), number3));
        }

        static int GetMax(int number, int number2)
        {
            return Math.Max(number, number2);
        }
    }
}
