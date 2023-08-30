using Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public abstract class Command : ICommand
    {
        public abstract void Execute();
    }
}
