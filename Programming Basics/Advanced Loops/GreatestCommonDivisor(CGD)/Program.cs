using System;

namespace GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            while (number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }

            Console.WriteLine(number1);
        }
    }
}
