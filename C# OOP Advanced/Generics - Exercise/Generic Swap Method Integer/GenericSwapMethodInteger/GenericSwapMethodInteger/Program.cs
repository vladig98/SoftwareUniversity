using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());
            List<GenericBox<int>> elements = new List<GenericBox<int>>();

            for (int i = 0; i < numberOfIntegers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                GenericBox<int> box = new GenericBox<int>(number);
                elements.Add(box);
            }

            int[] indecies = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Swap(indecies, elements);

            elements.ForEach(x => Console.WriteLine(x));
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
