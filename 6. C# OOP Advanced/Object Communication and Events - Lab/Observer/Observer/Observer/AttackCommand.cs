using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class AttackCommand : Command
    {
        private IAttacker Attacker;

        public AttackCommand(IAttacker attacker)
        {
            Attacker = attacker;
        }

        public override void Execute()
        {
            Attacker.Attack();
        }
    }
}
