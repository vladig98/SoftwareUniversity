using System;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = Console.ReadLine().Split("|").Select(x => x).ToList<string>();

            arrays = arrays.Select(x => x).Reverse().ToList<string>();

            foreach (var item in arrays)
            {
                var arr = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Console.Write(string.Join(" ", arr));
                Console.Write(" ");
            }
        }
    }
}
