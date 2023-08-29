using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int part1 = int.Parse(Console.ReadLine());
            int part2 = int.Parse(Console.ReadLine());
            int part3 = int.Parse(Console.ReadLine());
            int part4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", part1, part2, part3, part4);
        }
    }
}
