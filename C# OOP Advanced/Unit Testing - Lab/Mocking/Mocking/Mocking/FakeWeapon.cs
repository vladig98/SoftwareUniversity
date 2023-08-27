namespace Mocking
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
