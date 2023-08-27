using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfRectangles = inputParams[0];
            int numberOfIntersectionChecks = inputParams[1];

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                string id = inputTokens[0];
                double width = double.Parse(inputTokens[1]);
                double height = double.Parse(inputTokens[2]);
                double topLeftCornerX = double.Parse(inputTokens[3]);
                double topLeftCornerY = double.Parse(inputTokens[4]);

                rectangles.Add(new Rectangle(id, width, height, topLeftCornerX, topLeftCornerY));
            }

            for (int i = 0; i < numberOfIntersectionChecks; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");

                string rect1Id = inputTokens[0];
                string rect2Id = inputTokens[1];

                Rectangle rect1 = rectangles.Where(x => x.Id == rect1Id).FirstOrDefault();
                Rectangle rect2 = rectangles.Where(x => x.Id == rect2Id).FirstOrDefault();

                Console.WriteLine(rect1.Intersect(rect2).ToString().ToLower());
            }
        }
    }
}
