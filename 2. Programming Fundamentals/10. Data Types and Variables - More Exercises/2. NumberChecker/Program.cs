using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                long temp = long.Parse(number);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
