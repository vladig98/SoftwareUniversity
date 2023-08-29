using System;

namespace MakeaWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                word += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
