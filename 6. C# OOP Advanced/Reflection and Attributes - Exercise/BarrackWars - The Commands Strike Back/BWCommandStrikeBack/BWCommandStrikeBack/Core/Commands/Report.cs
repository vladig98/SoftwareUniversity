using BWCommandStrikeBack.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWCommandStrikeBack.Core.Commands
{
    public class Report : Command
    {
        protected Report(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }
    }
}
