using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<ICitizen> citizen = new List<ICitizen>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                if (citizen.All(x => ((INameAble)x).name != inputTokens[0]))
                {
                    if (inputTokens.Length > 3)
                    {
                        citizen.Add(new Citizen(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2], inputTokens[3]));
                    }
                    else
                    {
                        citizen.Add(new Rebel(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]));
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (citizen.Any(x => ((INameAble)x).name == input))
                {
                    ICitizen cz = citizen.FirstOrDefault(x => ((INameAble)x).name == input);
                    IBuyer buyer = (IBuyer)cz;
                    buyer.BuyFood();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(citizen.Sum(x => ((IBuyer)x).food));
        }
    }
}
