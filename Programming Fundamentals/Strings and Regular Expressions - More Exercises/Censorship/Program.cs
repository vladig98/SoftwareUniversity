using System;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(word, new string('*', word.Length));

            Console.WriteLine(sentence);
        }
    }
}
