using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] parts = Console.ReadLine().Split(">").ToArray();
            string input = Console.ReadLine();
            int punchPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    string number = string.Empty;
                    int counter = 1;
                    while (Regex.IsMatch(input[i + counter].ToString(), @"\d"))
                    {
                        number += input[i + counter];
                        counter++;
                    }
                    punchPower += int.Parse(number);
                }
                else if (input[i] != '>' && punchPower > 0)
                {
                    input = input.Remove(i, 1);
                    punchPower--;
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
