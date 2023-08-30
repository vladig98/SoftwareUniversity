using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
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

        private double money;

        public double Money
        {
            get { return money; }
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    throw new Exception();
                }
                money = value; 
            }
        }

        private List<Product> products;

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public Person(string name, double money)
        {
            products = new List<Product>();
            Name = name;
            Money = money;
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Products.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
}
