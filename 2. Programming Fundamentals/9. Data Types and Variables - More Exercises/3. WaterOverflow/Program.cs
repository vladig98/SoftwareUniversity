using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;

            int number = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (int i = 0; i < number; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters <= capacity - totalLiters)
                {
                    totalLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(totalLiters);
        }
    }
}
