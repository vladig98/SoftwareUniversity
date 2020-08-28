using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiplybignumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            Console.WriteLine(Multiply(number1, number2));
        }

        private static string Multiply (string number1, string number2)
        {
            string result = string.Empty;

            number1 = string.Join("", number1.Reverse());

            List<string> numbers = new List<string>();

            for (int i = 0; i < number1.Length; i++)
            {
                int digit = int.Parse(number1[i].ToString());
                string multiply = MultiplyBySingleDigit(digit, number2);
                multiply += new string('0', i);
                numbers.Add(multiply);
            }

            result = SumAllSums(numbers);

            if (result == "")
            {
                result = "0";
            }

            return result;
        }

        private static string SumAllSums(List<string> numbers)
        {
            string result = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                result = SumBigNumbers(result, numbers.ElementAt(i));
            }

            return result;
        }

        private static string SumBigNumbers(string number1, string number2)
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

        private static string MultiplyBySingleDigit(int number1, string number2)
        {
           number2 = string.Join("", number2.Reverse());

            int reminder = 0;
            string result = string.Empty;

            for (int i = 0; i < number2.Length; i++)
            {
                int digit = number1 * int.Parse(number2[i].ToString());

                digit += reminder;

                result += digit % 10;
                reminder = digit / 10;
            }

            if (reminder != 0)
            {
                result += reminder;
            }

            result = string.Join("", result.Reverse());

            if (result.Length > 1)
            {
                result = result.TrimStart('0');
            }

            return result;
        }
    }
}
