using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public string Name { get; private set; }
        public string Breed { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void EatFood(Food food, int quantity)
        {
            if (food is Vegetable || food is Meat)
            {
                FoodEaten += quantity;
                Weight += 0.3 * quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public Cat(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }
    }
}
