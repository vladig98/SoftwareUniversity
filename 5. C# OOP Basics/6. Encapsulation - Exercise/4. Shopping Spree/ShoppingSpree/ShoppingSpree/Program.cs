using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] peopleArguments = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productArguments = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (string peopleArgument in peopleArguments)
            {
                string[] tokens = peopleArgument.Split('=');
                try
                {
                    Person person = new Person(tokens[0], double.Parse(tokens[1]));
                    people.Add(person);
                }
                catch (Exception)
                {
                    return;
                }
            }

            foreach (string productArgument in productArguments)
            {
                string[] tokens = productArgument.Split('=');
                try
                {
                    Product product = new Product(tokens[0], double.Parse(tokens[1]));
                    products.Add(product);
                }
                catch (Exception)
                {
                    return;
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                Person person = people.Where(x => x.Name == tokens[0]).FirstOrDefault();
                Product product = products.Where(x => x.Name == tokens[1]).FirstOrDefault();

                person.BuyProduct(product);

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Products.Any())
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name).ToArray())}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
