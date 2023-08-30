using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corps, List<IMission> missions) : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
            foreach (IMission mission in missions)
            {
                this.missions.Add(mission);
            }
        }

        public List<IMission> missions { get; private set; }

        public override string ToString()
        {
            return missions.Count == 0 ? base.ToString() + string.Format($"{Environment.NewLine}Missions: ")
                : base.ToString() + string.Format($"{Environment.NewLine}Missions: {Environment.NewLine}") + string.Join(Environment.NewLine, 
                    missions.Select(x => "  " + x));
        }
    }
}
