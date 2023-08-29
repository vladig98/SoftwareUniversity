using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            while (number % 2 != 0)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }


        }
    }
}
