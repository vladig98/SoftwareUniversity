using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rows = 1;
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                count++;
                if (count == rows)
                {
                    rows++;
                    count = 0;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
