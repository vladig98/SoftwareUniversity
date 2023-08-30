using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corps, List<IRepair> repairs) : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
            foreach (IRepair repair in repairs)
            {
                this.repairs.Add(repair);
            }
        }

        public List<IRepair> repairs { get; private set; }

        public override string ToString()
        {
            return repairs.Count == 0 ? base.ToString() + string.Format($"{Environment.NewLine}Repairs: ")
                    : base.ToString() + string.Format($"{Environment.NewLine}Repairs: {Environment.NewLine}" +
                                                      $"{string.Join(Environment.NewLine, repairs.Select(x => "  " + x))}");
        }
    }
}
