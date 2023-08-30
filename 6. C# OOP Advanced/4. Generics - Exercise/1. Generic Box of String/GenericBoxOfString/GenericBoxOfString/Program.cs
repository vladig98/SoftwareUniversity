using System;

namespace GenericBoxOfString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfString = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfString; i++)
            {
                string input = Console.ReadLine();

                GenericBox<string> box = new GenericBox<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
