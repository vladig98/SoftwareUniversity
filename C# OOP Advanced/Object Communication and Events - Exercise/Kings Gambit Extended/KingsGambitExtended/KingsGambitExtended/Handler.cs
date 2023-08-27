using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace KingsGambitExtended
{
    public class Handler
    {
        public void OnKingUnderAttack(object o, UnderAttackEventArgs e)
        {
            if (o is King)
            {
                Console.WriteLine($"King {e.Name} is under attack!");
            }
            else if (o is Footman)
            {
                Console.WriteLine($"Footman {e.Name} is panicking!");
            }
            else if (o is RoyalGuard)
            {
                Console.WriteLine($"Royal Guard {e.Name} is defending!");
            }
        }
    }
}
