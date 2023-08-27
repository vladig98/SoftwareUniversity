using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            List<GenericBox<string>> elements = new List<GenericBox<string>>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();

                GenericBox<string> box = new GenericBox<string>(input);
                elements.Add(box);
            }

            string valueToCompare = Console.ReadLine();
            GenericBox<string> box2 = new GenericBox<string>(valueToCompare);

            Console.WriteLine(Compare(elements, box2));
        }

        public static int Compare<T>(List<GenericBox<T>> elements, GenericBox<T> element) where T : IComparable<T>
        {
            //int counter = 0;

            //foreach (T el in elements)
            //{
            //    if (el.CompareTo(element) > 0)
            //    {
            //        counter++;
            //    }
            //}

            //return counter;
            
            return elements.Where(x => x.CompareTo(element) > 0).Count();
        }
    }
}
