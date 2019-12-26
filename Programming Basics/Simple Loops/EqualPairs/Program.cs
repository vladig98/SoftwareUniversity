using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int previousSum = 0;
            int maxDiff = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int temp1 = int.Parse(Console.ReadLine());
                int temp2 = int.Parse(Console.ReadLine());

                int temp = temp1 + temp2;

                if (i == 0)
                {
                    previousSum = temp;
                }

                maxDiff = Math.Max(maxDiff, Math.Abs(temp - previousSum));

                maxValue = Math.Max(maxValue, temp);
                minValue = Math.Min(minValue, temp);

                previousSum = temp;
            }

            if (maxValue == minValue)
            {
                Console.WriteLine($"Yes, value={maxValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
