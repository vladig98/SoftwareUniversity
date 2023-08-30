using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface IObserver
    {
        void Update(int value);
    }
}
