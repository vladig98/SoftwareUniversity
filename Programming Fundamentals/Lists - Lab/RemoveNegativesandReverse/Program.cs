using System;
using System.Linq;

namespace RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            numbers = numbers.Where(x => x > 0).Select(x => x).Reverse().ToList<int>();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
