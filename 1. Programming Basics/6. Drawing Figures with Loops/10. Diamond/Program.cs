using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberOfStars = number % 2 == 0 ? 2 : 1;
            int numberOfSpaces = number % 2 == 0 ? 2 : 1;
            int diff = 2;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number - 1)
                {
                    if (number % 2 == 0 && i == number - 1)
                    {
                        return;
                    }
                    Console.WriteLine("{0}{1}{0}", 
                        new string('-', (number - numberOfStars) / 2), 
                        new string('*', numberOfStars));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", 
                        new string('-', (number - numberOfStars) / 2 - (int)Math.Ceiling(numberOfSpaces / 2.0)), 
                        new string('*', (int)Math.Ceiling(numberOfStars / 2.0)),
                        new string('-', numberOfSpaces));

                    if (numberOfSpaces == number - 2)
                    {
                        diff = -2;
                    }

                    numberOfSpaces += diff;
                }
            }
        }
    }
}
