using System;
using System.Linq;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            Circle circle = new Circle();
            circle.Center = point;
            circle.Radius = input[2];
            input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Point point2 = new Point();
            point2.X = input[0];
            point2.Y = input[1];
            Circle circle2 = new Circle();
            circle2.Center = point2;
            circle2.Radius = input[2];

            bool areItersecting = Intersect(circle, circle2);

            if (areItersecting)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool Intersect(Circle circle, Circle circle2)
        {
            double d = Math.Sqrt(circle.Center.X * circle.Center.X + circle2.Center.Y * circle2.Center.Y);

            return d <= circle.Radius + circle2.Radius;
        }

        public class Circle
        {
            public int Radius { get; set; }
            public Point Center { get; set; }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
