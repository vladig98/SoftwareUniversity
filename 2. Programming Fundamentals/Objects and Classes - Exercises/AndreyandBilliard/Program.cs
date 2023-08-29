using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyandBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            Dictionary<string, double> products = new Dictionary<string, double>();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split("-").ToArray();

                if (products.ContainsKey(tokens[0]))
                {
                    products[tokens[0]] = double.Parse(tokens[1]);
                }
                else
                {
                    products.Add(tokens[0], double.Parse(tokens[1]));
                }
            }

            string command = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (command != "end of clients")
            {
                string[] tokens = command.Split(new[] { "-", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!products.ContainsKey(tokens[1]))
                {
                    command = Console.ReadLine();
                    continue;
                }

                Customer customer = customers.FirstOrDefault(x => x.Name == tokens[0]);

                customer = customer == null ? new Customer() : customer;

                customer.Name = customer.Name == null ? tokens[0] : customer.Name;

                if (customer.Products.ContainsKey(tokens[1]))
                {
                    customer.Products[tokens[1]] += int.Parse(tokens[2]);
                }
                else
                {
                    customer.Products.Add(tokens[1], int.Parse(tokens[2]));
                }

                if (!customers.Any(x => x.Name == tokens[0]))
                {
                    customers.Add(customer);
                }

                command = Console.ReadLine();
            }

            customers = customers.OrderBy(x => x.Name).ToList();

            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Products)
                {
                    Console.WriteLine($"-- {item2.Key} - {item2.Value}");
                }
                Console.WriteLine($"Bill: {item.Products.Sum(x => products[x.Key] * x.Value).ToString("F2")}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(x => x.Products.Sum(y => products[y.Key] * y.Value)).ToString("F2")}");
        }

        class Customer
        {
            public Customer()
            {
                this.Products = new Dictionary<string, int>();
            }
            public string Name { get; set; }
            public Dictionary<string, int> Products { get; set; }
        }
    }
}
