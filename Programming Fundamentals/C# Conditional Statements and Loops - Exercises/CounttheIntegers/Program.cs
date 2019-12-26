using System;

namespace CounttheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalIntegers = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    totalIntegers++;
                }
                catch (Exception)
                {
                    Console.WriteLine(totalIntegers);
                    return;
                }
            }
        }
    }
}
