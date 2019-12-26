using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            CalculateProperties(side, command);
        }

        private static void CalculateProperties(double side, string command)
        {
            switch (command)
            {
                case "face":
                    Console.WriteLine($"{(side * Math.Sqrt(2)).ToString("F2")}");
                    break;
                case "space":
                    Console.WriteLine($"{(side * Math.Sqrt(3)).ToString("F2")}");
                    break;
                case "volume":
                    Console.WriteLine($"{(Math.Pow(side, 3)).ToString("F2")}");
                    break;
                case "area":
                    Console.WriteLine($"{(6 * Math.Pow(side, 2)).ToString("F2")}");
                    break;
                default:
                    break;
            }
        }
    }
}
