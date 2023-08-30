using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCompounds = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < numberOfCompounds; i++)
            {
                string[] elementsFromCurrentCompound = Console.ReadLine().Split(" ");

                foreach (var elementFromCurrentCompound in elementsFromCurrentCompound)
                {
                    elements.Add(elementFromCurrentCompound);
                }
            }

            elements = elements.OrderBy(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
