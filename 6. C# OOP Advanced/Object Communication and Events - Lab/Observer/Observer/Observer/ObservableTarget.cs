using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class ObservableTarget : ITarget, ISubject
    {
        private const string THIS_DIED_EVENT = "{0} dies";

        private List<IObserver> observers;
        private string id;
        private int hp;
        private int reward;
        private bool eventTriggered;
        private readonly Logger EventLogger;

        public bool IsDead { get => this.hp <= 0; }

        public ObservableTarget(string id, int hp, int reward)
        {
            this.id = id;
            this.hp = hp;
            this.reward = reward;
            EventLogger = new EventLogger();
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(reward);
            }
        }

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

        public void Register(IObserver Observer)
        {
            observers.Add(Observer);
        }

        public void Unregister(IObserver Observer)
        {
            observers.Remove(Observer);
        }
    }
}
