using System;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine("Not Prime");
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
        }
    }
}
