using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(Food food, int quantity)
        {
            FoodEaten += quantity;
            Weight += 0.35 * quantity;
        }

        public double WingSize { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }

        public Hen(string name, double weight, double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
    }
}
