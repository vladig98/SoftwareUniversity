using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class UnderAttackEventArgs : EventArgs
    {
        public string Name { get; set; }

        public UnderAttackEventArgs(string name)
        {
            Name = name;
        }
    }
}
