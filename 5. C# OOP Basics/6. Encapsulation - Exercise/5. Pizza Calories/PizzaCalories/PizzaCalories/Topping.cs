using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private ToppingTypeEnum type;

        public string Type
        {
            get { return type.ToString(); }
            private set 
            {
                if (!Enum.TryParse(value.ToString().ToLower(), out ToppingTypeEnum result))
                {
                    Console.WriteLine($"Cannot place {value} on top of your pizza.");
                    throw new Exception();
                }
                type = result; 
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    Console.WriteLine($"{Type.First().ToString().ToUpper() + Type.Substring(1).ToLower()} weight should be in the range [1..50].");
                    throw new Exception();
                }
                weight = value; 
            }
        }

        private double modifier { get; set; }

        private void UpdateModifier()
        {
            if (Type == ToppingTypeEnum.meat.ToString())
            {
                modifier *= 1.2;
            }
            else if (Type == ToppingTypeEnum.veggies.ToString())
            {
                modifier *= 0.8;
            }
            else if (Type == ToppingTypeEnum.cheese.ToString())
            {
                modifier *= 1.1;
            }
            else if (Type == ToppingTypeEnum.sauce.ToString())
            {
                modifier *= 0.9;
            }
        }

        private double calories;

        public double Calories
        {
            get { return calories; }
            private set { calories = value; }
        }
        
        private void CalculateCalories()
        {
            Calories = Weight * 2 * modifier;
        }

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
            modifier = 1.0;
            UpdateModifier();
            CalculateCalories();
        }
    }
}
