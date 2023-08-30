using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            List<Animal> animals = new List<Animal>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                if (counter % 2 == 0)
                {
                    switch (inputTokens[0])
                    {
                        case "Owl":
                            animals.Add(new Owl(inputTokens[1], double.Parse(inputTokens[2]), double.Parse(inputTokens[3])));
                            break;
                        case "Hen":
                            animals.Add(new Hen(inputTokens[1], double.Parse(inputTokens[2]), double.Parse(inputTokens[3])));
                            break;
                        case "Mouse":
                            animals.Add(new Mouse(inputTokens[1], double.Parse(inputTokens[2]), inputTokens[3]));
                            break;
                        case "Dog":
                            animals.Add(new Dog(inputTokens[1], double.Parse(inputTokens[2]), inputTokens[3]));
                            break;
                        case "Cat":
                            animals.Add(new Cat(inputTokens[1], double.Parse(inputTokens[2]), inputTokens[3], inputTokens[4]));
                            break;
                        case "Tiger":
                            animals.Add(new Tiger(inputTokens[1], double.Parse(inputTokens[2]), inputTokens[3], inputTokens[4]));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Food food = null;
                    switch (inputTokens[0])
                    {
                        case "Vegetable":
                            food = new Vegetable();
                            break;
                        case "Fruit":
                            food = new Fruit();
                            break;
                        case "Meat":
                            food = new Meat();
                            break;
                        case "Seeds":
                            food = new Seeds();
                            break;
                        default:
                            break;
                    }

                    Animal animal = animals.Last();
                    animal.AskForFood();
                    animal.EatFood(food, int.Parse(inputTokens[1]));
                }

                input = Console.ReadLine();
                counter++;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
