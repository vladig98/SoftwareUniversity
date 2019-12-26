using System;

namespace GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            int lastI = 0;
            int lastJ = 0;

            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    counter++;
                    if (i + j == magicalNumber)
                    {
                        lastI = i;
                        lastJ = j;
                    }
                }
            }
            if (lastI == 0 && lastJ == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {lastI} + {lastJ} = {magicalNumber}");
            }
        }
    }
}
