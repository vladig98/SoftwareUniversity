using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract void AskForFood();
        public abstract void EatFood(Food food, int quantity);
    }
}
