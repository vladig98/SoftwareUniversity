using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //code to refactor

            //int ___Do___ = int.Parse(Console.ReadLine());
            //for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
            //{
            //    bool TowaLIE = true;
            //    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
            //    {
            //        if (DAVIDIM % delio == 0)
            //        {
            //            TowaLIE = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
            //}

            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
