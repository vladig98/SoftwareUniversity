using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int weekdayAgeBetween0and18 = 12;
            const int weekdayAgeBetween18and64 = 18;
            const int weekdayAgeBetween64and122 = 12;

            const int weekendAgeBetween0and18 = 15;
            const int weekendAgeBetween18and64 = 20;
            const int weekendAgeBetween64and122 = 15;
            
            const int holidayAgeBetween0and18 = 5;
            const int holidayAgeBetween18and64 = 12;
            const int holidayAgeBetween64and122 = 10;

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine($"{weekdayAgeBetween0and18}$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine($"{weekdayAgeBetween18and64}$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{weekdayAgeBetween64and122}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine($"{weekendAgeBetween0and18}$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine($"{weekendAgeBetween18and64}$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{weekendAgeBetween64and122}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine($"{holidayAgeBetween0and18}$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine($"{holidayAgeBetween18and64}$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{holidayAgeBetween64and122}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
