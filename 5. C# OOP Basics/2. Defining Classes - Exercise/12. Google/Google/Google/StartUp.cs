using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                Person person;

                if (people.Any(x => x.Name == inputTokens[0]))
                {
                    person = people.Where(x => x.Name == inputTokens[0]).FirstOrDefault();
                }
                else
                {
                    person = new Person(inputTokens[0]);
                    people.Add(person);
                }

                switch (inputTokens[1])
                {
                    case "company":
                        Company company = new Company(inputTokens[2], inputTokens[3], double.Parse(inputTokens[4]));
                        person.AddCompany(company);
                        break;
                    case "pokemon":
                        Pokemon pokemon = new Pokemon(inputTokens[2], inputTokens[3]);
                        person.AddPokemon(pokemon);
                        break;
                    case "parents":
                        Parent parent = new Parent(inputTokens[2], inputTokens[3]);
                        person.AddParent(parent);
                        break;
                    case "children":
                        Child child = new Child(inputTokens[2], inputTokens[3]);
                        person.AddChild(child);
                        break;
                    case "car":
                        Car car = new Car(inputTokens[2], int.Parse(inputTokens[3]));
                        person.AddCar(car);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            Person personToPrint = people.Where(x => x.Name == input).FirstOrDefault();

            Console.WriteLine(personToPrint);
        }
    }
}
