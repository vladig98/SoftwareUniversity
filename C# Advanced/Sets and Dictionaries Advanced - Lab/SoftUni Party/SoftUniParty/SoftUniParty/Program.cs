using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            const string partyStart = "party";
            const string partyEnd = "end";

            HashSet<string> VIPs = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != partyEnd)
            {
                if (Regex.IsMatch(input, @"\d.{7,7}"))
                {
                    VIPs.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                if (input.ToLower() == partyStart)
                {
                    while (input.ToLower() != partyEnd)
                    {
                        VIPs.Remove(input);
                        regularGuests.Remove(input);

                        input = Console.ReadLine();
                    }
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPs.Count + regularGuests.Count);
            foreach (var vip in VIPs)
            {
                if (vip.Length == 8)
                {
                    Console.WriteLine(vip);
                }
            }
            foreach (var guest in regularGuests)
            {
                if (guest.Length == 8)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
