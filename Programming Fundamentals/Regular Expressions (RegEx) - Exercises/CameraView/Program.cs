using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|\<[^\|\<]+";

            int[] steps = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            string sentence = Console.ReadLine();

            List<string> results = new List<string>();

            MatchCollection matches = Regex.Matches(sentence, pattern);

            foreach (Match match in matches)
            {
                string result = string.Join("", match.Value.ToCharArray().Skip(steps[0] + 2).Take(steps[1]));
                results.Add(result);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
