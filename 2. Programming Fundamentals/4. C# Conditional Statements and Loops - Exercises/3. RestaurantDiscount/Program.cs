using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            const int smallhallPrice = 2500;
            const int terracePrice = 5000;
            const int greathallPrice = 7500;
            
            const int smallhallCapacity = 50;
            const int terraceCapacity = 100;
            const int greathallCapacity = 120;

            const int discountNormal = 5;
            const int discountGold = 10;
            const int discountPlatinum = 15;
            
            const int priceNormal = 500;
            const int priceGold = 750;
            const int pricePlatinum = 1000;

            int size = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            switch (package)
            {
                case "Normal":
                    if (size <= smallhallCapacity)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((smallhallPrice + priceNormal) - (smallhallPrice + priceNormal) * discountNormal / 100.0) / size);
                    }
                    else if (size > smallhallCapacity && size <= terraceCapacity)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:F2}$", ((terracePrice + priceNormal) - (terracePrice + priceNormal) * discountNormal / 100.0) / size);
                    }
                    else if (size > terraceCapacity && size <= greathallCapacity)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((greathallPrice + priceNormal) - (greathallPrice + priceNormal) * discountNormal / 100.0) / size);
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
                case "Gold":
                    if (size <= smallhallCapacity)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((smallhallPrice + priceGold) - (smallhallPrice + priceGold) * discountGold / 100.0) / size);
                    }
                    else if (size > smallhallCapacity && size <= terraceCapacity)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:F2}$", ((terracePrice + priceGold) - (terracePrice + priceGold) * discountGold / 100.0) / size);
                    }
                    else if (size > terraceCapacity && size <= greathallCapacity)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((greathallPrice + priceGold) - (greathallPrice + priceGold) * discountGold / 100.0) / size);
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
                case "Platinum":
                    if (size <= smallhallCapacity)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((smallhallPrice + pricePlatinum) - (smallhallPrice + pricePlatinum) * discountPlatinum / 100.0) / size);
                    }
                    else if (size > smallhallCapacity && size <= terraceCapacity)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:F2}$", ((terracePrice + pricePlatinum) - (terracePrice + pricePlatinum) * discountPlatinum / 100.0) / size);
                    }
                    else if (size > terraceCapacity && size <= greathallCapacity)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:F2}$", ((greathallPrice + pricePlatinum) - (greathallPrice + pricePlatinum) * discountPlatinum / 100.0) / size);
                    }
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
