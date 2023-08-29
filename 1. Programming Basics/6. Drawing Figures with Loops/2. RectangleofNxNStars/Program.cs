using System;

namespace RectangleofNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(new string('*', number));
            }
        }
    }
}
