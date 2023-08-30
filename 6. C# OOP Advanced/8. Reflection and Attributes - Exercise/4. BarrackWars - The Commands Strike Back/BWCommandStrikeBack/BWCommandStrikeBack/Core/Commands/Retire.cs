using BWCommandStrikeBack.Contracts;
using BWCommandStrikeBack.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWCommandStrikeBack.Core.Commands
{
    public class Retire : Command
    {
        protected Retire(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            string output = string.Empty;

            if (((UnitRepository)Repository).DoesntHaveUnit(unitType))
            {
                output = "No such units in repository.";
            }
            else
            {
                Repository.RemoveUnit(unitType);
                output = $"{unitType} retired!";
            }

            return output;
        }
    }
}
