using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ").ToArray();

            Action<string[]> printer = n => n.ToList().ForEach(x => Console.WriteLine(x));

            printer(names);
        }
    }
}
