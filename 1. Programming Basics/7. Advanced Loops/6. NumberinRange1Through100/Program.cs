using System;

namespace NumberinRange1Through100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine($"The number is: {number}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (number < 1 || number > 100);
        }
    }
}
