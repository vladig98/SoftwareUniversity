using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bytes = Console.ReadLine().Split(" ").ToList<string>();

            bytes = bytes.Where(x => x.Length == 2).Select(x => string.Join("", x.Reverse())).Reverse().Select(x => ((char)Convert.ToInt32(x, 16)).ToString()).ToList<string>();

            Console.WriteLine(string.Join("", bytes));
        }
    }
}
