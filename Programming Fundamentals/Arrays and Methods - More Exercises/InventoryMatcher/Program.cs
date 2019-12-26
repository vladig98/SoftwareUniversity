using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(" ").ToArray();
            string[] quantity = Console.ReadLine().Split(" ").ToArray();
            string[] prices = Console.ReadLine().Split(" ").ToArray();

            string cmd = Console.ReadLine();

            while (cmd != "done")
            {
                int index = Array.IndexOf(products, cmd);
                Console.WriteLine($"{cmd} costs: {prices[index]}; Available quantity: {quantity[index]}");
                cmd = Console.ReadLine();
            }
        }
    }
}
