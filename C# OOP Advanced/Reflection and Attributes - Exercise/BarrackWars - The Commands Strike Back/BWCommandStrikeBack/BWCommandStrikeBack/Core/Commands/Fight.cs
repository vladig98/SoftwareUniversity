using BWCommandStrikeBack.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWCommandStrikeBack.Core.Commands
{
    public class Fight : Command
    {
        protected Fight(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
