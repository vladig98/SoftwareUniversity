using System;

namespace DrawingTool
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Shape shape = null;

            switch (input)
            {
                case "Square":
                    shape = new Square(int.Parse(Console.ReadLine()));
                    break;
                case "Rectangle":
                    shape = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                default:
                    break;
            }

            DrawingTool drawingTool = new DrawingTool(shape);
        }
    }
}
