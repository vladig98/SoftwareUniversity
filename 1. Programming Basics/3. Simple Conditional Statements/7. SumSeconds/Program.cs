using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            seconds += int.Parse(Console.ReadLine());
            seconds += int.Parse(Console.ReadLine());

            int minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine(String.Format("{0}:{1:D2}", minutes, seconds));
        }
    }
}
