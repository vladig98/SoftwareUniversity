using System;

namespace Comparingfloats
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal precision = 0.000001M;

            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());

            decimal diff = Math.Abs(number1 - number2);

            if (diff < precision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
