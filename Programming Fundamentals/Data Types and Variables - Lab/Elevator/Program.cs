using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int paeopleToElevate = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(paeopleToElevate / (double)capacity));
        }
    }
}
