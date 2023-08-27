using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class FootballTeam
    {
        private List<Player> players;

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("A name should not be empty.");
                    throw new Exception();
                }
                name = value; 
            }
        }

        public double Rating => players.Count == 0 ? 0 : Math.Round(players.Sum(x => x.OverallSkill) / players.Count);

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            if (!players.Any(x => x.Name == name))
            {
                Console.WriteLine($"Player {name} is not in {Name} team.");
                throw new Exception();
            }

            Player player = players.FirstOrDefault(x => x.Name == name);

            players.Remove(player);
        }

        public FootballTeam(string name)
        {
            players = new List<Player>();
            Name = name;
        }
    }
}
