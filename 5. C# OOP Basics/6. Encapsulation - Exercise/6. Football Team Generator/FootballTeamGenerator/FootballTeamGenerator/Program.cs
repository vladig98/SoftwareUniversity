using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<FootballTeam> teams = new List<FootballTeam>();

            while (input != "END")
            {
                string[] inputTokens = input.Split(';');
                FootballTeam team = null;
                Player player = null;

                switch (inputTokens[0])
                {
                    case "Team":
                        try
                        {
                            teams.Add(new FootballTeam(inputTokens[1]));
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "Add":
                        team = teams.Where(x => x.Name == inputTokens[1]).FirstOrDefault();
                        if (team == null)
                        {
                            Console.WriteLine($"Team {inputTokens[1]} does not exist.");
                            break;
                        }
                        try
                        {
                            player = new Player(inputTokens[2], int.Parse(inputTokens[3]), int.Parse(inputTokens[4]),
                                                        int.Parse(inputTokens[5]), int.Parse(inputTokens[6]), int.Parse(inputTokens[7]));
                            team.AddPlayer(player);
                        }
                        catch (Exception)
                        {
                        }
                        
                        break;
                    case "Remove":
                        team = teams.Where(x => x.Name == inputTokens[1]).FirstOrDefault();
                        try
                        {
                            team.RemovePlayer(inputTokens[2]);
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "Rating":
                        team = teams.Where(x => x.Name == inputTokens[1]).FirstOrDefault();
                        if (team == null)
                        {
                            Console.WriteLine($"Team {inputTokens[1]} does not exist.");
                            break;
                        }
                        Console.WriteLine($"{team.Name} - {team.Rating}");
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
