using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface ISubject
    {
        void Register(IObserver Observer);
        void Unregister(IObserver Observer);
        void NotifyObservers();
    }
}
