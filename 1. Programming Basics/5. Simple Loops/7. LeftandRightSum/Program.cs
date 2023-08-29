using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < number; i++)
            {
                sum1 += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
