using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set 
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty");
                    throw new Exception();
                }
                name = value; 
            }
        }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    throw new Exception();
                }
                cost = value; 
            }
        }


    }
}
