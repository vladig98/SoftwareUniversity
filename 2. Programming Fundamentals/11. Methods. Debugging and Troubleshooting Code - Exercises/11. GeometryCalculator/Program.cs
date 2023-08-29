using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            GetShape(figure);
        }

        private static void GetShape(string figure) 
        {
            switch (figure)
            {
                case "triangle":
                    double sideT = double.Parse(Console.ReadLine());
                    double heightT = double.Parse(Console.ReadLine());
                    CalculateTriangleArea(sideT, heightT);
                    break;
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    CalculateSquareArea(side);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    CalculateRectangleArea(width, height);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    CalculateCircleArea(radius);
                    break;
                default:
                    break;
            }
        }

        private static void CalculateCircleArea(double radius)
        {
            Console.WriteLine("{0:F2}", Math.PI * radius * radius);
        }

        private static void CalculateRectangleArea(double width, double height)
        {
            Console.WriteLine("{0:F2}", width * height);
        }

        private static void CalculateSquareArea(double side)
        {
            Console.WriteLine("{0:F2}", side * side);
        }

        private static void CalculateTriangleArea(double sideT, double heightT)
        {
            Console.WriteLine("{0:F2}", sideT * heightT / 2.0);
        }
    }
}
