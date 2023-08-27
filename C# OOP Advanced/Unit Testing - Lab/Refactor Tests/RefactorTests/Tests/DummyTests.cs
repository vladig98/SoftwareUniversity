using NUnit.Framework;
using RefactorTests;
using System;

namespace Tests
{
    public class DummyTests
    {
        private const int DUMMY_HEALTH = 10;
        private const int DUMMY_EXPERIENCE = 10;
        private const int DUMMY_DEAD_HEALTH = 0;
        private const int DUMMY_TO_TAKE_DAMAGE = 5;
        private const string FAIL_MESSAGE_FOR_ATTACK_DUMMY = "Dummy is not taking damage.";
        private const string EXPECTED_MESSAGE_FOR_ATTACKING_A_DEAD_DUMMY = "Dummy is dead.";
        private const string FAIL_MESSAGE_FOR_ATTACKING_A_DEAD_DUMMY = "There is no exception thrown for a dead dummy.";
        private const string FAIL_MESSAGE_FOR_A_DEAD_DUMMY_GIVING_XP = "No XP was returned or the number was incorrect.";
        private const string EXPECTED_RESULT_FOR_DUMMY_GIVING_XP = "Target is not dead.";
        private const string FAIL_MESSAGE_FOR_DUMMY_GIVING_XP = "Alive dummies should not return XP.";

        private Dummy Dummy;
        private Dummy DeadDummy;

        private int ResultForAttackDummy;

        [SetUp]
        public void Init()
        {
            Dummy = new Dummy(DUMMY_HEALTH, DUMMY_EXPERIENCE);
            DeadDummy = new Dummy(DUMMY_DEAD_HEALTH, DUMMY_EXPERIENCE);
            ResultForAttackDummy = DUMMY_HEALTH - DUMMY_TO_TAKE_DAMAGE;
        }

        [Test]
        public void DummyLoosesHealthAfterAttack()
        {
            Dummy.TakeAttack(DUMMY_TO_TAKE_DAMAGE);
            Assert.That(Dummy.Health, Is.EqualTo(ResultForAttackDummy), FAIL_MESSAGE_FOR_ATTACK_DUMMY);
        }

        [Test]
        public void AttackADeadDummy()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() => DeadDummy.TakeAttack(DUMMY_TO_TAKE_DAMAGE));

            Assert.That(ex.Message, Is.EqualTo(EXPECTED_MESSAGE_FOR_ATTACKING_A_DEAD_DUMMY), FAIL_MESSAGE_FOR_ATTACKING_A_DEAD_DUMMY);
        }

        [Test]
        public void CanADeadDummyGiveXP()
        {
            int xp = DeadDummy.GiveExperience();

            Assert.That(xp, Is.EqualTo(DUMMY_EXPERIENCE), FAIL_MESSAGE_FOR_A_DEAD_DUMMY_GIVING_XP);
        }

        [Test]
        public void CanAnAliveDummyGiveXP()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() => Dummy.GiveExperience());

            Assert.That(ex.Message, Is.EqualTo(EXPECTED_RESULT_FOR_DUMMY_GIVING_XP), FAIL_MESSAGE_FOR_DUMMY_GIVING_XP);
        }
    }
}
