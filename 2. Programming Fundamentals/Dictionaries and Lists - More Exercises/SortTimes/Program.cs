using System;
using System.Linq;

namespace SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = Console.ReadLine().Split(" ").ToArray();
            times = times.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", times));
        }
    }
}
