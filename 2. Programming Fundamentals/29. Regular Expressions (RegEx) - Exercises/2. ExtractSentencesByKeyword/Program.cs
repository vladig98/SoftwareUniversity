using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = @"\b" + word + @"\b";

            string[] sentences = Console.ReadLine().Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
