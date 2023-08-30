using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 20;

        public int DurabilityPoints => 20;

        public void Attack(ITarget target)
        {
        }
    }
}
