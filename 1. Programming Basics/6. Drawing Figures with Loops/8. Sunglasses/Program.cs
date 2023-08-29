using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
                for (int j = 0; j < number; j++)
                {
                    if (j == 0 || j == number - 1)
                    {
                        Console.Write(new string('*', number * 2));
                        Console.Write(new string(' ', number));
                        Console.WriteLine(new string('*', number * 2));
                    }
                    else
                    {
                        Console.Write($"*{new string('/', number * 2 - 2)}*");
                        if (j == Math.Ceiling(number / 2.0) - 1)
                        {
                            Console.Write(new string('|', number));
                        }
                        else
                        {
                            Console.Write(new string(' ', number));
                        }
                        Console.WriteLine($"*{new string('/', number * 2 - 2)}*");
                    }
                }
            //}
        }
    }
}
