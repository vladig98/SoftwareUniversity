using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double sumEven = 0;

            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double sumOdd = 0;

            for (int i = 1; i <= number; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += temp;
                    maxEven = Math.Max(maxEven, temp);
                    minEven = Math.Min(minEven, temp);
                }
                else
                {
                    sumOdd += temp;
                    maxOdd = Math.Max(maxOdd, temp);
                    minOdd = Math.Min(minOdd, temp);
                }
            }

            if (sumOdd == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd},");
                Console.WriteLine($"OddMin={minOdd},");
                Console.WriteLine($"OddMax={maxOdd},");

                if (sumEven == 0)
                {
                    Console.WriteLine("EvenSum=0,");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenSum={sumEven},");
                    Console.WriteLine($"EvenMin={minEven},");
                    Console.WriteLine($"EvenMax={maxEven}");
                }
            }
        }
    }
}
