using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                string word = Console.ReadLine();

                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        result += word + delimiter;
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    if (i % 2 != 0)
                    {
                        result += word + delimiter;
                    }
                }
            }

            Console.WriteLine(result.Remove(result.Length - 1, 1));
        }
    }
}
