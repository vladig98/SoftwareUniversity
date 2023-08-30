namespace InfernoInfinityBonus.Models.Units
{
    public class Sword : Weapon
    {
        private const int NUMBER_OF_SOCKETS = 3;
        private const int MIN_DAMAGE = 4;
        private const int MAX_DAMAGE = 6;

        public Sword(string name, string rarity) : base(name, rarity, NUMBER_OF_SOCKETS, MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}
