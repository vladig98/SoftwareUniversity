using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < limit; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                min = Math.Min(min, temp);
            }

            Console.WriteLine(min);
        }
    }
}
