using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int index = 0;
            int sum = 0;

            while (true)
            {
                sum += numbers[index];
                if (index + numbers[index] >= numbers.Length)
                {
                    if (index - numbers[index] < 0)
                    {
                        break;
                    }
                    else
                    {
                        index = index - numbers[index];
                    }
                }
                else
                {
                    index = index + numbers[index];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
