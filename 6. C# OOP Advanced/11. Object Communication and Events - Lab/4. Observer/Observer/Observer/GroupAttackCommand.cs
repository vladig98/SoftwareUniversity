using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class GroupAttackCommand : Command
    {
        private IAttackGroup attackGroup;

        public GroupAttackCommand(IAttackGroup attackGroup)
        {
            this.attackGroup = attackGroup;
        }

        public override void Execute()
        {
            attackGroup.GroupAttack();
        }
    }
}