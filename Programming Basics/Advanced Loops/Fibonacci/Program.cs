using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int element0 = 1;
            int element1 = 1;

            int element = int.Parse(Console.ReadLine());

            if (element < 2) 
            {
                Console.WriteLine(element0);
                return;
            }

            for (int i = 2; i <= element; i++)
            {
                int temp = element1;
                element1 += element0;
                element0 = temp;
            }

            Console.WriteLine(element1);
        }
    }
}
