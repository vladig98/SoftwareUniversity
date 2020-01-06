using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = string.Join("", input.ToCharArray().Reverse());

            Console.WriteLine(input);
        }
    }
}
