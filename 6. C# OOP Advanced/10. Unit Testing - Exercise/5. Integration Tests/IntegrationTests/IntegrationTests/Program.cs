using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegrationTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ");

                try
                {
                    switch (tokens[0])
                    {
                        case "AddCategory":
                            engine.AddCategory(tokens[1]);
                            break;
                        case "AddUser":
                            engine.AddUser(tokens[1]);
                            break;
                        case "RemoveCategory":
                            engine.RemoveCategory(tokens[1]);
                            break;
                        case "RemoveCategories":
                            engine.RemoveCategories(tokens.Skip(1).ToList());
                            break;
                        case "AssignChildCategory":
                            engine.AssignChildCategory(tokens[1], tokens[2]);
                            break;
                        case "AssignUserCategory":
                            engine.AssignUserCategory(tokens[1], tokens[2]);
                            break;
                        case "RemoveChild":
                            engine.RemoveChild(tokens[1], tokens[2]);
                            break;
                        case "RemoveChildren":
                            engine.RemoveChildren(tokens[1], tokens.Skip(2).ToList());
                            break;
                        case "Print":
                            engine.Print();
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
