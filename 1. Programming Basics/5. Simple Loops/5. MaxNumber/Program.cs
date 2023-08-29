using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 0; i < limit; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                max = Math.Max(max, temp);
            }

            Console.WriteLine(max);
        }
    }
}
