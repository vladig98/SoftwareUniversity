using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<ISoldier> soldiers = new List<ISoldier>();

            while (input != "End")
            {
                string[] inputTokens = input.Split(' ');

                switch (inputTokens[0])
                {
                    case "Private":
                        soldiers.Add(new Private(inputTokens[1], inputTokens[2], inputTokens[3], 
                            double.Parse(inputTokens[4])));
                        break;
                    case "LieutenantGeneral":
                        List<IPrivate> privates = new List<IPrivate>();
                        string[] LGTokens = inputTokens.Skip(5).ToArray();
                        foreach (string LGToken in LGTokens)
                        {
                            privates.Add((IPrivate)soldiers.Where(x => ((ISoldier)x).id == LGToken).FirstOrDefault());
                        }
                        soldiers.Add(new LeutenantGeneral(inputTokens[1], inputTokens[2], inputTokens[3], 
                            double.Parse(inputTokens[4]), privates));
                        break;
                    case "Engineer":
                        List<IRepair> repairs = new List<IRepair>();
                        string[] ETokens = inputTokens.Skip(6).ToArray();
                        for (int i = 0; i < ETokens.Length; i += 2)
                        {
                            repairs.Add(new Repair(ETokens[i], int.Parse(ETokens[i + 1])));
                        }

                        ISoldier engineer = new Engineer(inputTokens[1], inputTokens[2], inputTokens[3],
                            double.Parse(inputTokens[4]), inputTokens[5], repairs);
                        if (!((ISpecialisedSoldier)engineer).parsed)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        soldiers.Add(engineer);
                        break;
                    case "Commando":
                        List<IMission> missions = new List<IMission>();
                        string[] CTokens = inputTokens.Skip(6).ToArray();
                        for (int i = 0; i < CTokens.Length; i += 2)
                        {
                            IMission mission = new Mission(CTokens[i], CTokens[i + 1]);
                            if (!mission.parsed)
                            {
                                continue;
                            }
                            missions.Add(mission);
                        }

                        ISoldier commando = new Commando(inputTokens[1], inputTokens[2], inputTokens[3],
                            double.Parse(inputTokens[4]), inputTokens[5], missions);
                        if (!((ISpecialisedSoldier)commando).parsed)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        soldiers.Add(commando);
                        break;
                    case "Spy":
                        soldiers.Add(new Spy(inputTokens[1], inputTokens[2], inputTokens[3], int.Parse(inputTokens[4])));
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (ISoldier soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
