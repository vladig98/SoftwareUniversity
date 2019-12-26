using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePremiere = 12;
            const double priceNormal = 7.5;
            const double priceDiscount = 5;

            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            switch (projection)
            {
                case "Premiere":
                    Console.WriteLine(rows * cols * pricePremiere);
                    break;
                case "Normal":
                    Console.WriteLine(rows * cols * priceNormal);
                    break;
                case "Discount":
                    Console.WriteLine(rows * cols * priceDiscount);
                    break;
                default:
                    break;
            }
        }
    }
}
