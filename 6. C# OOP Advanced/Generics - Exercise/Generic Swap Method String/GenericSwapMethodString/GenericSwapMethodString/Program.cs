using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfString = int.Parse(Console.ReadLine());
            List<GenericBox<string>> elements = new List<GenericBox<string>>();

            for (int i = 0; i < numberOfString; i++)
            {
                string input = Console.ReadLine();

                GenericBox<string> box = new GenericBox<string>(input);
                elements.Add(box);
            }

            int[] indecies = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            Swap(indecies, elements);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        public static void Swap<T>(int[] indecies, List<T> elements)
        {
            int firstIndex = indecies[0];
            int secondIndex = indecies[1];

            T firstElement = elements.ElementAt(firstIndex);
            T secondElement = elements.ElementAt(secondIndex);

            elements.RemoveAt(firstIndex);
            elements.Insert(firstIndex, secondElement);
            elements.RemoveAt(secondIndex);
            elements.Insert(secondIndex, firstElement);
        }
    }
}
