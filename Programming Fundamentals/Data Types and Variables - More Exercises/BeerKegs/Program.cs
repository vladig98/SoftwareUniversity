using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string kegNameMaxVolume = string.Empty;
            double kegVolumeMaxVolume = 0;

            for (int i = 0; i < number; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > kegVolumeMaxVolume)
                {
                    kegVolumeMaxVolume = volume;
                    kegNameMaxVolume = model;
                }
            }

            Console.WriteLine(kegNameMaxVolume);
        }
    }
}
