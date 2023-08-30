using System;
using System.Collections.Generic;
using System.Linq;

namespace KingsGambit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kingsName = Console.ReadLine();
            string[] royalGuardsNames = Console.ReadLine().Split(' ');
            string[] footmenNames = Console.ReadLine().Split(" ");

            string command = Console.ReadLine();

            Handler handler = new Handler();

            List<RoyalGuard> royalGuards = new List<RoyalGuard>();
            List<Footman> footmen = new List<Footman>();

            for (int i = 0; i < royalGuardsNames.Length; i++)
            {
                royalGuards.Add(new RoyalGuard(royalGuardsNames[i]));
            }

            for (int i = 0; i < footmenNames.Length; i++)
            {
                footmen.Add(new Footman(footmenNames[i]));
            }

            King king = new King(handler, footmen, royalGuards, kingsName);

            king.UnderAttack += new UnderAttackEventHandler(handler.OnKingUnderAttack);

            while (command != "End")
            {
                string[] inputTokens = command.Split(" ");

                switch (inputTokens[0])
                {
                    case "Attack":
                        king.OnUnderAttack(new UnderAttackEventArgs(king.Name));
                        break;
                    case "Kill":
                        if (royalGuards.Any(x => x.Name == inputTokens[1]))
                        {
                            royalGuards.Where(x => x.Name == inputTokens[1]).FirstOrDefault().Kill();
                        }

                        if (footmen.Any(x => x.Name == inputTokens[1]))
                        {
                            footmen.Where(x => x.Name == inputTokens[1]).FirstOrDefault().Kill();
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
