using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int divider = int.Parse(Console.ReadLine());

            Action<List<int>> reverse = numbers => numbers.Reverse();
            Action<List<int>> exclude = numbers => numbers.RemoveAll(n => n % divider == 0);
            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            reverse(numbers);
            exclude(numbers);
            print(numbers);
        }
    }
}
