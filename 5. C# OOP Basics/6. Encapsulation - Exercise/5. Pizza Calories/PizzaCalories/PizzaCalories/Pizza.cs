using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                    throw new Exception();
                }
                name = value; 
            }
        }

        private List<Topping> toppings;

        private Dough dough;

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }


        public double Calories
        {
            get { return toppings.Sum(x => x.Calories) + Dough.Calories; }
            private set { }
        }

        public int NumberOfToppings { get => toppings.Count; private set { } }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
                throw new Exception();
            }
            toppings.Add(topping);
        }

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public override string ToString()
        {
            return string.Format($"{Name} - {Calories:F2} Calories.");
        }
    }
}
