using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            sbyte priceSbyte = 0;
            int priceInt = 0;

            try
            {
                priceSbyte = sbyte.Parse(number);
                priceInt = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                priceInt = int.Parse(number);
                priceSbyte = sbyte.Parse(Console.ReadLine());
            }

            long total = 10 * (long)priceInt;
            total += 4 * (long)priceSbyte;
            Console.WriteLine(total);
        }
    }
}
