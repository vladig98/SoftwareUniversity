using System;

namespace RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to refactor

            //double dul, sh, V = 0;
            //Console.Write("Length: ");
            //dul = double.Parse(Console.ReadLine());
            //Console.Write("Width: ");
            //sh = double.Parse(Console.ReadLine());
            //Console.Write("Heigth: ");
            //V = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;
            //Console.WriteLine("Pyramid Volume: {0:F2}", V);

            double length, width, height = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = length * width * height / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
