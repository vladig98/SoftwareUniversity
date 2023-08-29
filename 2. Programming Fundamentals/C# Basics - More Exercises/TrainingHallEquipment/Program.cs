using System;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                if (count > 1)
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }
                totalPrice += price * count;
            }

            Console.WriteLine($"Subtotal: ${totalPrice.ToString("F2")}");
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Money left: ${(budget - totalPrice).ToString("F2")}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(totalPrice - budget).ToString("F2")} more.");
            }
        }
    }
}
