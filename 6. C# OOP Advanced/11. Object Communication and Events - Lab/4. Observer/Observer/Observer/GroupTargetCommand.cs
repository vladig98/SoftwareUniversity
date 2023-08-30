using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class GroupTargetCommand : Command
    {
        private IAttackGroup attackGroup;
        private ITarget target;

        public GroupTargetCommand(IAttackGroup attackGroup, ITarget target)
        {
            this.attackGroup = attackGroup;
            this.target = target;
        }

        public override void Execute()
        {
            attackGroup.GroupTarget(this.target);
        }
    }
}
