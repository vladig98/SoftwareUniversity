using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambitExtended
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
