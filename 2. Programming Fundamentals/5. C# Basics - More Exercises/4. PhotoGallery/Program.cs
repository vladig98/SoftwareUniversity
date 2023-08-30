using System;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = string.Empty;
            string bytes = "B";
            double newSize = 0;

            if (size >= 1000)
            {
                bytes = "KB";
                newSize = size / 1000;
                if (newSize >= 1000)
                {
                    bytes = "MB";
                    newSize /= 1000;
                    if (newSize >= 1000)
                    {
                        bytes = "GB";
                        newSize /= 1000;
                        if (newSize >= 1000)
                        {
                            bytes = "TB";
                            newSize /= 1000;
                        }
                    }
                }
            }
            else
            {
                newSize = size;
            }

            if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            else
            {
                orientation = "landscape";
            }

            Console.WriteLine($"Name: DSC_{photoNumber.ToString("D4")}.jpg");
            Console.WriteLine($"Date Taken: {day.ToString("D2")}/{month.ToString("D2")}/{year} {hours.ToString("D2")}:{minutes.ToString("D2")}");
            Console.WriteLine($"Size: {newSize}{bytes}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
