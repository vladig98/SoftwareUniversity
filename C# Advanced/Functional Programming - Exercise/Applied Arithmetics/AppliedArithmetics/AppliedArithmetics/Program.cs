using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, List<int>> add = nums => nums.Select(n => ++n).ToList();
            Func<List<int>, List<int>> multiply = nums => nums.Select(n => n * 2).ToList();
            Func<List<int>, List<int>> subtract = nums => nums.Select(n => --n).ToList();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            string input = Console.ReadLine();

            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
