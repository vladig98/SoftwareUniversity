using NUnit.Framework;
using RefactorTests;

namespace Tests
{
    public class AxeTests
    {
        private const int AXE_ATTACK = 10;
        private const int AXE_DURABILITY = 10;
        private const int DUMMY_HEALTH = 10;
        private const int DUMMY_EXPERIENCE = 10;
        private const string MESSAGE_FOR_FAILURE = "Axe Durability doesn't change after attack.";

        private Axe Axe;
        private Dummy Dummy;

        private int ExpectedResult;

        [SetUp]
        public void Init()
        {
            Axe = new Axe(AXE_ATTACK, AXE_DURABILITY);
            Dummy = new Dummy(DUMMY_HEALTH, DUMMY_EXPERIENCE);
            ExpectedResult = AXE_DURABILITY - 1;
        }

        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            Axe.Attack(Dummy);

            Assert.That(Axe.DurabilityPoints, Is.EqualTo(ExpectedResult), MESSAGE_FOR_FAILURE);
        }
    }
}
