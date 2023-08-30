using System;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(
                new[] { ".", ",", ":", ";", "(", ")", "[", "]", "\"", "\'", "\\", "/", "!", "?", " "}, 
                StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            words = words.Where(x => x.Length < 5).Distinct().OrderBy(x => x).Select(x => x).ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
