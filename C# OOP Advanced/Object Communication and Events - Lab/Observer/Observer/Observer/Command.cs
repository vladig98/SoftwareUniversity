using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Heroes
{
    public abstract class Command : ICommand
    {
        public abstract void Execute();
    }
}
