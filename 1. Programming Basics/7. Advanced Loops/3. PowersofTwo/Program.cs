using System;

namespace PowersofTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
