using FakeAxeAndDummy;
using NUnit.Framework;

namespace Tests
{
    public class HeroTests
    {
        private const string HERO_NAME = "Pesho";
        private const int EXPERIENCE_POINTS = 20;
        private const string FAIL_MESSAGE = "Target does not return any XP.";

        [Test]
        public void HeroGainsExperienceAffterAttackIfTargetDies()
        {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeapon();

            Hero hero = new Hero(HERO_NAME, fakeWeapon);
            hero.Attack(fakeTarget);

            Assert.That(hero.Experience, Is.EqualTo(EXPERIENCE_POINTS), FAIL_MESSAGE);
        }
    }
}
