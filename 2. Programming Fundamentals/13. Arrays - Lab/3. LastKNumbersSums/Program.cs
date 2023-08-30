using System;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int offset = 0;

                for (int j = numbers.Length - 1; j >= numbers.Length - k - offset; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    if (numbers[j] == 0)
                    {
                        offset++;
                        continue;
                    }
                    sum += numbers[j];
                }

                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}