using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Group : IAttackGroup
    {
        private List<IAttacker> attackers;

        public Group()
        {
            attackers = new List<IAttacker>();
        }

        public void AddMember(IAttacker Attacker)
        {
            attackers.Add(Attacker);
        }

        public void GroupAttack()
        {
            foreach (var attacker in attackers)
            {
                attacker.Attack();
            }
        }

        public void GroupTarget(ITarget Target)
        {
            foreach (var attacker in attackers)
            {
                attacker.SetTarget(Target);
            }
        }

        public void GroupTargetAndAttack(ITarget target)
        {
            foreach (var attacker in attackers)
            {
                attacker.SetTarget(target);
                attacker.Attack();
            }
        }
    }
}
