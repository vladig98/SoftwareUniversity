using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 1;
            string animalType = string.Empty;

            List<Animal> animals = new List<Animal>();

            while (input != "Beast!")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter % 2 != 0)
                {
                    if (inputTokens.Length == 0)
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }
                    animalType = inputTokens[0];
                }
                else
                {
                    if (inputTokens.Length < 3 || !int.TryParse(inputTokens[1], out int result))
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        counter++;
                        continue;
                    }

                    try
                    {
                        switch (animalType)
                        {
                            case "Cat":
                                animals.Add(new Cat(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                                break;
                            case "Dog":
                                animals.Add(new Dog(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                                break;
                            case "Frog":
                                animals.Add(new Frog(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                                break;
                            case "Kitten":
                                animals.Add(new Kitten(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                                break;
                            case "Tomcat":
                                animals.Add(new Tomcat(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                                break;
                            default:
                                Console.WriteLine("Invalid input!");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                input = Console.ReadLine();
                counter++;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
