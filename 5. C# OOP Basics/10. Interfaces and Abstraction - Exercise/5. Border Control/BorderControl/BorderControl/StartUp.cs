using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<ICitizen> citizen = new List<ICitizen>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                if (inputTokens.Length > 2)
                {
                    citizen.Add(new Citizen(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                }
                else
                {
                    citizen.Add(new Robot(inputTokens[0], inputTokens[1]));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            DetainFactory detain = new DetainFactory(input);

            foreach (var citizen1 in citizen)
            {
                if (detain.ShouldDetain(citizen1))
                {
                    Console.WriteLine(citizen1.id);
                }
            }
        }
    }
}
