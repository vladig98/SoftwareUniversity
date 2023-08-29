using System;

namespace NumbersinReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            PrintDigits(number);
        }

        private static void PrintDigits(double number)
        {
            string num = number.ToString();
            string result = string.Empty;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += num[i];
            }

            Console.WriteLine(result);
        }
    }
}
