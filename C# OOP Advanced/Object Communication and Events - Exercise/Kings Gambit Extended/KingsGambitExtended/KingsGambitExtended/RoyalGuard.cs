using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambitExtended
{
    public class RoyalGuard
    {
        public string Name { get; set; }
        public bool IsKilled { get; set; }

        private int counter = 0;

        public RoyalGuard(string name)
        {
            Name = name;
            IsKilled = false;
        }

        public void Kill()
        {
            if (++counter % 3 == 0)
            {
                IsKilled = true;
            }
        }
    }
}
