using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberOfStars = number % 2 == 0 ? 2 : 1;

            for (int i = 0; i < Math.Floor((number + 1) / 2.0); i++)
            {
                int spaces = (number - numberOfStars) / 2;

                Console.Write(new string('-', spaces));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', spaces));

                numberOfStars += 2;
            }

            for (int i = 0; i < Math.Floor(number / 2.0); i++)
            {
                Console.WriteLine($"|{new string('*', number - 2)}|");
            }
        }
    }
}
