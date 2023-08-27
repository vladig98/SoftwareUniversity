using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Warrior : AbstractHero
    {
        private const string ATTACK_MESSAGE = "{0} damages {1} for {2}";

        public Warrior(string id, int damage, Logger combatLogger) : base(id, damage, combatLogger)
        {
        }

        protected override void ExecuteClassSpecificAttack(ITarget target, int damage)
        {
            CombatLogger.Handle(LogType.ATTACK, string.Format(ATTACK_MESSAGE, this, target, damage));
            //Console.WriteLine(ATTACK_MESSAGE, this, target, damage);
        }
    }
}
