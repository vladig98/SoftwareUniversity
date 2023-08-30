using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Citizen> citizens = new List<Citizen>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                citizens.Add(new Citizen(inputTokens[0],inputTokens[1], int.Parse(inputTokens[2])));

                input = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
