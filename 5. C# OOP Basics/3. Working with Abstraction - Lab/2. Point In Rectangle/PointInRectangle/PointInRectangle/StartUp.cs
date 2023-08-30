using System;
using System.Linq;

namespace PointInRectangle
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double[] cordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Rectangle rect = new Rectangle(new Point(cordinates[0], cordinates[1]), new Point(cordinates[2], cordinates[3]));

            int numberOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPoints; i++)
            {
                double[] pointCordinates = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

                Point point = new Point(pointCordinates[0], pointCordinates[1]);

                Console.WriteLine(rect.Contains(point));
            }
        }
    }
}
