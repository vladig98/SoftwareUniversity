using System;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            DateTime converted = DateTime.ParseExact(date, "d-M-yyyy", null);
            Console.WriteLine(converted.DayOfWeek);
        }
    }
}
