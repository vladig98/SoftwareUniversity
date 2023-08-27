using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void EatFood(Food food, int quantity)
        {
            if (food is Fruit || food is Vegetable)
            {
                FoodEaten += quantity;
                Weight += 0.1 * quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public Mouse(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }
    }
}
