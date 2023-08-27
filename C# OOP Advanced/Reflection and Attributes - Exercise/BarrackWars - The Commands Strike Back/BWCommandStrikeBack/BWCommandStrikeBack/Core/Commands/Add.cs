using BWCommandStrikeBack.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWCommandStrikeBack.Core.Commands
{
    public class Add : Command
    {
        protected Add(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = UnitFactory.CreateUnit(unitType);
            Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
