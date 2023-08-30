using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string[]> printer = n => n.ToList().ForEach(x => Console.WriteLine("Sir " + x));

            printer(names);
        }
    }
}
