using System;
using System.Linq;
using System.Numerics;

namespace Convertfrombase_10tobase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(" ").Select(BigInteger.Parse).ToArray();

            string converted = string.Empty;

            if (numbers[1] == 0)
            {
                Console.WriteLine("0");
                return;
            }

            while (numbers[1] > 0)
            {
                BigInteger bit = numbers[1] % numbers[0];
                BigInteger newNumber = numbers[1] / numbers[0];
                converted += bit;
                numbers[1] = newNumber;
            }

            Console.WriteLine(string.Join("", converted.ToCharArray().Reverse()));
        }
    }
}
