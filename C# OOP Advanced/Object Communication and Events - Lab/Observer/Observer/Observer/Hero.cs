using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero : IAttacker, IObserver
    {
        private const string TARGET_NULL_MESSAGE = "Target is null.";
        private const string NO_TARGET_MESSAGE = "{0} has no target.";
        private const string TARGET_DEAD_MESSAGE = "{0} is dead.";
        private const string SET_TARGET_MESSAGE = "{0} targets {1}.";
        private const string ATTACK_MESSAGE = "{0} damages {1} for {2}";

        private string id;
        private int damage;
        private ITarget target;
        protected readonly Logger CombatLogger;
        protected readonly ICommand AttackCommand;

        public int Reward = 0;

        public Hero(string id, int damage, Logger combatLogger)
        {
            this.id = id;
            this.damage = damage;
            CombatLogger = combatLogger;
            AttackCommand = new AttackCommand(this);
        }

        public void Attack()
        {
            if (this.target == null)
            {
                CombatLogger.Handle(LogType.ATTACK, string.Format(NO_TARGET_MESSAGE, this));
                //Console.WriteLine(NO_TARGET_MESSAGE, this);
            }
            else if (this.target.IsDead)
            {
                CombatLogger.Handle(LogType.ATTACK, string.Format(TARGET_DEAD_MESSAGE, this.target));
                //Console.WriteLine(TARGET_DEAD_MESSAGE, this.target);
            }
            else
            {
                this.ExecuteClassSpecificAttack(this.target, this.damage);
            }
        }

        public void SetTarget(ITarget target)
        {
            if (target == null)
            {
                CombatLogger.Handle(LogType.TARGET, string.Format(TARGET_NULL_MESSAGE));
                //Console.WriteLine(TARGET_NULL_MESSAGE);
            }
            else
            {
                this.target = target;

                CombatLogger.Handle(LogType.TARGET, string.Format(SET_TARGET_MESSAGE, this, target));
                //Console.WriteLine(SET_TARGET_MESSAGE, this, target);
            }
        }

        protected void ExecuteClassSpecificAttack(ITarget target, int damage)
        {
            CombatLogger.Handle(LogType.ATTACK, string.Format(ATTACK_MESSAGE, this, target, damage));
            //Console.WriteLine(ATTACK_MESSAGE, this, target, damage);
        }

        public void Update(int value)
        {
            Reward += value;
        }
    }
}
