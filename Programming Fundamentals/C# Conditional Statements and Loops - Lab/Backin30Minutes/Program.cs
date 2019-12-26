using System;

namespace Backin30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += hours * 60 + 30;

            hours = minutes / 60;
            minutes -= hours * 60;
            hours %= 24;

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
