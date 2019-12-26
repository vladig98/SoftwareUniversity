using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int numberOfIngredients = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                numberOfIngredients++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
        }
    }
}
