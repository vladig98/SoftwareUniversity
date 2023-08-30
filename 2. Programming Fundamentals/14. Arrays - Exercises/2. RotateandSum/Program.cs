using System;
using System.Linq;

namespace RotateandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                    sum[j] += numbers[j];
                }
                numbers[0] = temp;
                sum[0] += numbers[0];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
