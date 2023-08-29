using System;
using System.Linq;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] parts = email.Split("@").ToArray();

            if (parts[1].Sum(x => x) - parts[0].Sum(x => x) <= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
