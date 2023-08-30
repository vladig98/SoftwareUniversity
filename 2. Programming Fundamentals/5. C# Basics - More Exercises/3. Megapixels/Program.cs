using System;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            long pixels = width * height;
            double megaPixels = pixels / 1_000_000.0;

            Console.WriteLine($"{width}x{height} => {Math.Round(megaPixels, 1)}MP");
        }
    }
}
