using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < until; i++)
            {
                string input = Console.ReadLine();
                Point point = new Point(input.Split(" ").Select(double.Parse).ToArray()[0], input.Split(" ").Select(double.Parse).ToArray()[1]);

                points.Add(point);
            }

            FindClosestPoints(points);
        }

        private static void FindClosestPoints(List<Point> points)
        {
            double minimal = double.MaxValue;
            Point pointA = null;
            Point pointB = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = Distance(points.ElementAt(i), points.ElementAt(j));

                    if (distance < minimal)
                    {
                        minimal = distance;
                        pointA = points.ElementAt(i);
                        pointB = points.ElementAt(j);
                    }
                }
            }

            Console.WriteLine(minimal);
            Console.WriteLine(pointA.ToString());
            Console.WriteLine(pointB.ToString());
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

            public override string ToString()
            {
                return $"({this.X}, {this.Y})";
            }
        }
    }
}
