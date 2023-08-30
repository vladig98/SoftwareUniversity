using BWReturnDependency.Contracts;
using System;

namespace BWReturnDependency.Core.Commands
{
    public class Fight : Command
    {
        protected Fight(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
