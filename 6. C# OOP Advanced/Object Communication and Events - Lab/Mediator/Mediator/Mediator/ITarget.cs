using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface ITarget
    {
        void ReceiveDamage(int damage);

        bool IsDead { get; }
    }
}
