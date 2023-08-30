using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> longerThanLength = (n, l) => SumCharacters(n) >= l;

            FindLongerNames(names, length, longerThanLength);
        }

        private static void FindLongerNames(List<string> names, int length, Func<string, int, bool> longerThanLength)
        {
            foreach (var name in names)
            {
                if (longerThanLength(name, length))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }

        private static int SumCharacters(string n)
        {
            return n.Sum(x => x);
        }
    }
}
