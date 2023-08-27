using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class Footman
    {
        public string Name { get; set; }
        public bool IsKilled { get; set; }

        public Footman(string name)
        {
            Name = name;
            IsKilled = false;
        }

        public void Kill()
        {
            IsKilled = true;
        }
    }
}
