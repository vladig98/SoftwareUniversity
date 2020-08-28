using System;
using System.Linq;
using System.Numerics;

namespace Convertfrombase_Ntobase_10
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

            BigInteger sum = 0;
            converted = numbers[1].ToString();

            for (int i = 0; i < converted.Length; i++)
            {
                sum += int.Parse(converted[converted.Length - i - 1].ToString()) * Power((int)numbers[0], i);
            }

            Console.WriteLine(sum);
        }

        public static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
