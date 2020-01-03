using System;
using System.Globalization;
using System.Linq;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(input1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(input2, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11]
            {
                new DateTime(2019, 1, 1),
                new DateTime(2019, 3, 3),
                new DateTime(2019, 5, 1),
                new DateTime(2019, 5, 6),
                new DateTime(2019, 5, 24),
                new DateTime(2019, 9, 6),
                new DateTime(2019, 9, 22),
                new DateTime(2019, 11, 1),
                new DateTime(2019, 12, 24),
                new DateTime(2019, 12, 25),
                new DateTime(2019, 12, 26)
            };

            int days = 0;

            for (DateTime i = date1; i <= date2; i = i.AddDays(1))
            {
                if (!isHoliday(i, holidays))
                {
                    days++;
                }
            }

            Console.WriteLine(days);
        }

        private static bool isHoliday(DateTime i, DateTime[] holidays)
        {
            return holidays.Any(x => x.Day == i.Day && x.Month == i.Month) || i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
