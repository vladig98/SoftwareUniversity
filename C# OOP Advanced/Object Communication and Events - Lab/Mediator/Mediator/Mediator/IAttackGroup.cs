using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface IAttackGroup
    {
        void AddMember(IAttacker Attacker);
        void GroupTarget(ITarget Target);
        void GroupAttack();
    }
}
