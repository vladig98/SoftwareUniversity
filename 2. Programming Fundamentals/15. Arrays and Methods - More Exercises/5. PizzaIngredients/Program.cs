using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(" ").ToArray();
            int length = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < ingredients.Length && counter < 10; i++)
            {
                if (ingredients[i].Length == length)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    counter++;
                }
            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients.Where(x => x.Length == length).Select(x => x).Take(10).ToArray())}.");
        }
    }
}
