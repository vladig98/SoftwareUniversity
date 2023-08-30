using Mocking;
using Moq;
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
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(x => x.Health).Returns(0);
            fakeTarget.Setup(x => x.GiveExperience()).Returns(EXPERIENCE_POINTS);
            fakeTarget.Setup(x => x.IsDead()).Returns(true);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero("Pesho", fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.That(hero.Experience, Is.EqualTo(EXPERIENCE_POINTS), FAIL_MESSAGE);
        }
    }
}
