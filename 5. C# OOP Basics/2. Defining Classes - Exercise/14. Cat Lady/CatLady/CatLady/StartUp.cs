using System;
using System.Collections.Generic;
using System.Linq;

namespace CatLady
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Cat> cats = new List<Cat>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                string catType = inputTokens[0];
                string catName = inputTokens[1];
                string catValue = inputTokens[2];

                switch (catType)
                {
                    case "Siamese":
                        cats.Add(new Siamese(catName, int.Parse(catValue)));
                        break;
                    case "Cymric":
                        cats.Add(new Cymric(catName, double.Parse(catValue)));
                        break;
                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire(catName, int.Parse(catValue)));
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var cat = cats.Where(x => x.Name == input).FirstOrDefault();

            if (cat is Siamese)
            {
                Console.WriteLine($"{cat.Type} {cat.Name} {((Siamese)(cat)).EarSize}");
            }

            if (cat is Cymric)
            {
                Console.WriteLine($"{cat.Type} {cat.Name} {((Cymric)(cat)).FurLength:F2}");
            }

            if (cat is StreetExtraordinaire)
            {
                Console.WriteLine($"{cat.Type} {cat.Name} {((StreetExtraordinaire)(cat)).DecibelsOfMeows}");
            }
        }
    }
}
