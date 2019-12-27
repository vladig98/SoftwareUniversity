using System;
using System.Linq;

namespace DistancebetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Point pointA = new Point(input.Split(" ").Select(double.Parse).ToArray()[0], input.Split(" ").Select(double.Parse).ToArray()[1]);
            input = Console.ReadLine();
            Point pointB = new Point(input.Split(" ").Select(double.Parse).ToArray()[0], input.Split(" ").Select(double.Parse).ToArray()[1]);

            Console.WriteLine(Distance(pointA, pointB));
        }

        private static double Distance(Point pointA, Point pointB)
        {
            double sideA = Math.Abs(pointA.X - pointB.X);
            double sideB = Math.Abs(pointA.Y - pointB.Y);

            double sideASquared = sideA * sideA;
            double sideBSquared = sideB * sideB;

            double difference = sideASquared + sideBSquared;

            return Math.Sqrt(difference);
        }

        public class Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
