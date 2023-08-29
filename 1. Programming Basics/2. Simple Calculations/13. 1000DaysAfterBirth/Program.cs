using System;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            date = date.AddDays(999);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
