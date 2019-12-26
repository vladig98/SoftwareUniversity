using System;

namespace SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] arr = new bool[number + 1];

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (arr[i] == true)
                {
                    for (int j = i * i; j <= number; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
