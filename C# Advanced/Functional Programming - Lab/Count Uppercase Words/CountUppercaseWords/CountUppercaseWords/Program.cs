using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = word => word[0] == word.ToUpper()[0];

            words.Where(checker).ToList().ForEach(word => Console.WriteLine(word));
        }
    }
}
