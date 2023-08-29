using System;

namespace WordinPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            switch (word[word.Length - 1])
            {
                case 'y':
                    Console.WriteLine(word.Remove(word.Length - 1, 1) + "ies");
                    break;
                case 'o':
                case 's':
                case 'x':
                case 'z':
                    Console.WriteLine(word + "es");
                    break;
                case 'h':
                    if (word[word.Length - 2] == 'c' || word[word.Length - 2] == 's')
                    {
                        Console.WriteLine(word + "es");
                    }
                    break;
                default:
                    Console.WriteLine(word + "s");
                    break;
            }
        }
    }
}
