using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            const int weekends = 48;

            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsOff = int.Parse(Console.ReadLine());

            double games = ((weekends - weekendsOff) * 3 / 4.0) + weekendsOff + (holidays * 2 / 3.0);

            if (year == "leap")
            {
                games += games * 0.15;
            }

            Console.WriteLine(Math.Floor(games));
        }
    }
}
