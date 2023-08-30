using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = Console.ReadLine();
            string part2 = Console.ReadLine();
            Object obj = part1 + " " + part2;

            string whole = obj.ToString();

            Console.WriteLine(whole);
        }
    }
}
