using System;
using System.Collections.Generic;

namespace CustomListIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GenericList<string> list = new GenericList<string>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                CommandInterpreter(tokens[0], tokens, list);

                input = Console.ReadLine();
            }
        }

        private static void CommandInterpreter<T>(string command, string[] tokens, GenericList<T> list) where T : IComparable<T>
        {
            switch (command)
            {
                case "Add":
                    list.Add((T)Convert.ChangeType(tokens[1], typeof(T)));
                    break;
                case "Remove":
                    list.Remove(int.Parse(tokens[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains((T)Convert.ChangeType(tokens[1], typeof(T))));
                    break;
                case "Swap":
                    list.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan((T)Convert.ChangeType(tokens[1], typeof(T))));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    ((List<T>)(list.Elements)).ForEach(x => Console.WriteLine(x));
                    break;
                default:
                    break;
            }
        }
    }
}
