using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            List<GenericBox<double>> elements = new List<GenericBox<double>>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                double input = double.Parse(Console.ReadLine());

                GenericBox<double> box = new GenericBox<double>(input);
                elements.Add(box);
            }

            double valueToCompare = double.Parse(Console.ReadLine());
            GenericBox<double> box2 = new GenericBox<double>(valueToCompare);

            Console.WriteLine(Compare(elements, box2));
        }

        public static int Compare<T>(List<GenericBox<T>> elements, GenericBox<T> element) where T : IComparable<T>
        {
            return elements.Where(x => x.CompareTo(element) > 0).Count();
        }
    }
}
