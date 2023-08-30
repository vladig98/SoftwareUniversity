using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool boolean = Convert.ToBoolean(input);

            string result = boolean == true ? "Yes" : "No";

            Console.WriteLine(result);
        }
    }
}
