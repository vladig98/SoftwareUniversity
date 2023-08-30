using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambitExtended
{
    public delegate void UnderAttackEventHandler(King o, UnderAttackEventArgs e);

    public class King
    {
        public string Name { get; set; }

        private List<Footman> Footmen { get; set; }
        private List<RoyalGuard> RoyalGuards { get; set; }
        private Handler handler;

        public event UnderAttackEventHandler UnderAttack;

        public King(Handler handler, List<Footman> footmen, List<RoyalGuard> guards, string name)
        {
            Footmen = footmen;
            RoyalGuards = guards;

            this.handler = handler;

            Name = name;
        }

        public void OnUnderAttack(UnderAttackEventArgs e)
        {
            handler.OnKingUnderAttack(this, new UnderAttackEventArgs(Name));

            foreach (RoyalGuard royalGuard in RoyalGuards)
            {
                if (!royalGuard.IsKilled)
                {
                    handler.OnKingUnderAttack(royalGuard, new UnderAttackEventArgs(royalGuard.Name));
                }
            }

            foreach (Footman footman in Footmen)
            {
                if (!footman.IsKilled)
                {
                    handler.OnKingUnderAttack(footman, new UnderAttackEventArgs(footman.Name));
                }
            }
        }
    }
}
