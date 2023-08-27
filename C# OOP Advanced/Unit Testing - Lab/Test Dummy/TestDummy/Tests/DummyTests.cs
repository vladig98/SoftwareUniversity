using NUnit.Framework;
using System;
using TestDummy;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void DummyLoosesHealthAfterAttack()
        {
            Dummy dummy = new Dummy(20, 10);
            dummy.TakeAttack(5);

            Assert.That(dummy.Health, Is.EqualTo(15));
        }

        [Test]
        public void AttackADeadDummy()
        {
            Dummy dummy = new Dummy(0, 10);

            Exception ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5));

            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void CanADeadDummyGiveXP()
        {
            Dummy dummy = new Dummy(0, 10);

            int xp = dummy.GiveExperience();

            Assert.That(xp, Is.EqualTo(10));
        }

        [Test]
        public void CanAnAliveDummyGiveXP()
        {
            Dummy dummy = new Dummy(5, 10);

            Exception ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
