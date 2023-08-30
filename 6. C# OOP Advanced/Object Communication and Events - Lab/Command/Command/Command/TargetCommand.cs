using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class TargetCommand : Command
    {
        private IAttacker Attacker;
        private ITarget Target;

        public TargetCommand(IAttacker attacker, ITarget target)
        {
            Attacker = attacker;
            Target = target;
        }

        public override void Execute()
        {
            Attacker.SetTarget(Target);
        }
    }
}
