using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();

            while (command != "JOKER")
            {
                string[] tokens = command.Split(":").ToArray();
                string[] hand = tokens[1].Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
                if (cards.ContainsKey(tokens[0]))
                {
                    cards[tokens[0]].AddRange(hand.Distinct());
                }
                else
                {
                    cards.Add(tokens[0], hand.Distinct().ToList<string>());
                }
                command = Console.ReadLine();
            }

            Dictionary<string, int> temp = cards.ToDictionary(y => y.Key, x => CalculatePoints(x.Value.Distinct().ToArray()));

            foreach (var item in temp)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static int CalculatePoints(string[] hand)
        {
            int total = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                string[] handTokens = hand[i].ToCharArray().Select(x => x.ToString()).ToArray();
                int value = 0;
                int suit = 0;
                if (handTokens.Length > 2)
                {
                    value = 10;
                    suit = GetSuit(handTokens[2]);
                }
                else
                {
                    value = GetValue(handTokens[0]);
                    suit = GetSuit(handTokens[1]);
                }
                total += value * suit;
            }
            return total;
        }

        private static int GetValue(string value)
        {
            switch (value)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(value);
            }
        }

        private static int GetSuit(string suit)
        {
            switch (suit)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
