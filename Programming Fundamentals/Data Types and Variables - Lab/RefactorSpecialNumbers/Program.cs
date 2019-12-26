using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //code to refactor

            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0; int takova = 0; bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine($"{takova} -> {toe}");
            //    obshto = 0;
            //    ch = takova;
            //}

            int number = int.Parse(Console.ReadLine());
            int sum = 0; 
            int currentNumber = 0; 
            bool isSpecial = false;

            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;
            }
        }
    }
}
