using System;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && IsTheSumOfDigitsDivisibleBy7(i) && IsThereAnEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsThereAnEvenDigit(int number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length; i++)
            {
                int temp = int.Parse(num[i].ToString());
                if (temp % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsTheSumOfDigitsDivisibleBy7(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsPalindrome(int number)
        {
            string numbertoText = number.ToString();

            string reversed = string.Empty;

            for (int i = numbertoText.Length - 1; i >= 0; i--)
            {
                reversed += numbertoText[i];
            }

            int reversedNumber = int.Parse(reversed);

            if (reversedNumber == number)
            {
                return true;
            }

            return false;
        }
    }
}
