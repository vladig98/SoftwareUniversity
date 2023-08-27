using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake();
            lake.Jump(numbers);

            Console.WriteLine(String.Join(", ", lake.Path));
        }
    }
}
