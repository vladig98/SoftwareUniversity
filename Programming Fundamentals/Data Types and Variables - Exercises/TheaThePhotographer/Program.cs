using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredImages = (long)Math.Ceiling(numberOfPictures * filterFactor / 100.0);
            long totalTime = numberOfPictures * filterTime;
            totalTime += filteredImages * uploadTime;

            long days = totalTime / 86400;
            totalTime -= days * 86400;
            long hours = totalTime / 3600;
            totalTime -= hours * 3600;
            long minutes = totalTime / 60;
            totalTime -= minutes * 60;
            long seconds = totalTime;

            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);
        }
    }
}
