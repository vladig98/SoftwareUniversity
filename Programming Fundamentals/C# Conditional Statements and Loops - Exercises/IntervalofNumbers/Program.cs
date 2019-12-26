using System;

namespace IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int lower = Math.Min(number1, number2);
            int higher = Math.Max(number1, number2);

            for (int i = lower; i <= higher; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
