using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.2).ToList().ForEach(x => Console.WriteLine("{0:F2}", x));
        }
    }
}
