using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface IAttacker
    {
        void Attack();

        void SetTarget(ITarget target);
    }
}
