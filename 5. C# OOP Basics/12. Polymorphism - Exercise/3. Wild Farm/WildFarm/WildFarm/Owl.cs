using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public double WingSize { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void EatFood(Food food, int quantity)
        {
            if (food is Meat)
            {
                FoodEaten += quantity;
                Weight += 0.25 * quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }

        public Owl(string name, double weight, double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
    }
}
