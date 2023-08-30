using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Dragon : ITarget
    {
        private const string THIS_DIED_EVENT = "{0} dies";

        private string id;
        private int hp;
        private int reward;
        private bool eventTriggered;
        private readonly Logger EventLogger;

        public Dragon(string id, int hp, int reward)
        {
            this.id = id;
            this.hp = hp;
            this.reward = reward;
            EventLogger = new EventLogger();
        }

        public bool IsDead { get => this.hp <= 0; }

        public void ReceiveDamage(int damage)
        {
            if (!this.IsDead)
            {
                this.hp -= damage;
            }

            if (this.IsDead && !eventTriggered)
            {
                EventLogger.Handle(LogType.EVENT, string.Format(THIS_DIED_EVENT, this));
                //Console.WriteLine(THIS_DIED_EVENT, this);
                this.eventTriggered = true;
            }
        }

        public override string ToString()
        {
            return this.id;
        }
    }
}
