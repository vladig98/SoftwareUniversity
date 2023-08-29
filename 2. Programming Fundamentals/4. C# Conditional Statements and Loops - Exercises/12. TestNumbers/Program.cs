using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int limt = int.Parse(Console.ReadLine());
            int total = 0;
            int combinations = 0;

            for (int i = number1; i >= 1; i--)
            {
                for (int j = 1; j <= number2; j++)
                {
                    combinations++;
                    total += 3 * i * j;
                    if (total >= limt)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {total} >= {limt}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {total}");
        }
    }
}
