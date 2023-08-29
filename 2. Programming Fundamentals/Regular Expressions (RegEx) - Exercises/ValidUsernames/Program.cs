using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new[] { " ", "/", "\\", "(", ")" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            string pattern = @"\b[a-zA-Z][a-zA-Z_0-9]{2,24}\b";

            List<string> matchedUsernames = new List<string>();

            foreach (var username in usernames)
            {
                if (Regex.IsMatch(username, pattern))
                {
                    matchedUsernames.Add(Regex.Match(username, pattern).Value);
                }
            }

            int maxValue = 0;
            KeyValuePair<string, string> longestUsernames = new KeyValuePair<string, string>();

            for (int i = 0; i < matchedUsernames.Count - 1; i++)
            {
                if (maxValue < matchedUsernames.ElementAt(i).Length + matchedUsernames.ElementAt(i + 1).Length)
                {
                    maxValue = matchedUsernames.ElementAt(i).Length + matchedUsernames.ElementAt(i + 1).Length;
                    longestUsernames = new KeyValuePair<string, string>(matchedUsernames.ElementAt(i), matchedUsernames.ElementAt(i + 1));
                }
            }

            Console.WriteLine(longestUsernames.Key);
            Console.WriteLine(longestUsernames.Value);
        }
    }
}
