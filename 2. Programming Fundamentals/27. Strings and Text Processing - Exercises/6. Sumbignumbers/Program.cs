using System;
using System.Linq;

namespace Sumbignumbers
{
    class Program
    {
        static void Main(string[] args)
       {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            Console.WriteLine(Sum(number1, number2));
        }

        private static string Sum(string number1, string number2)
        {
            int difference = Math.Abs(number1.Length - number2.Length);

            if (number1.Length > number2.Length)
            { 
                number2 = string.Join("", (string.Join("", number2.Reverse()) + new string('0', difference)).Reverse());
            }
            else if (number1.Length < number2.Length)
            {
                number1 = string.Join("", (string.Join("", number1.Reverse()) + new string('0', difference)).Reverse());
            }

            string result = string.Empty;
            int reminder = 0;

            number1 = string.Join("", number1.Reverse());
            number2 = string.Join("", number2.Reverse());

            for (int i = 0; i < number1.Length; i++)
            {
                int digit = int.Parse(number1[i].ToString()) + int.Parse(number2[i].ToString());

                digit += reminder;

                result += digit % 10;
                reminder = digit / 10;
            }

            if (reminder != 0)
            {
                result += reminder;
            }

            result = string.Join("", result.Reverse());

            result = result.TrimStart('0');

            return result;
        }
    }
}
