using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
        {
            CorpsEnum parsedValue;
            if (Enum.TryParse(corps, out parsedValue))
            {
                this.corps = parsedValue;
                parsed = true;
            }
            else
            {
                parsed = false;
            }
        }

        public CorpsEnum corps { get; private set; }
        public bool parsed { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{Environment.NewLine}Corps: {corps.ToString()}");
        }
    }
}
