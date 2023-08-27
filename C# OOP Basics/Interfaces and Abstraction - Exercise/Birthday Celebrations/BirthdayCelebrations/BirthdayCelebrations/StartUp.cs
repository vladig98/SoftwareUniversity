using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
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

                switch (inputTokens[0])
                {
                    case "Citizen":
                        citizen.Add(new Citizen(inputTokens[1], int.Parse(inputTokens[2]), inputTokens[3], inputTokens[4]));
                        break;
                    case "Pet":
                        citizen.Add(new Pet(inputTokens[1], inputTokens[2]));
                        break;
                    case "Robot":
                        citizen.Add(new Robot(inputTokens[1], inputTokens[2]));
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            BirthDateFactory birthDateFactory = new BirthDateFactory(input);

            foreach (var citizen1 in citizen)
            {
                if (citizen1.GetType().Name != "Robot")
                {
                    if (birthDateFactory.DoBirthDatesMatch((IBirthDataAble)citizen1))
                    {
                        IBirthDataAble birthDataAble = (IBirthDataAble)citizen1;
                        Console.WriteLine(birthDataAble.birthDate.Trim());
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
