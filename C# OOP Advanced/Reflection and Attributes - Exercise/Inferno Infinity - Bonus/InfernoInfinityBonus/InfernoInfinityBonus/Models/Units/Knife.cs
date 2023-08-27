namespace InfernoInfinityBonus.Models.Units
{
    public class Knife : Weapon
    {
        private const int NUMBER_OF_SOCKETS = 2;
        private const int MIN_DAMAGE = 3;
        private const int MAX_DAMAGE = 4;

        public Knife(string name, string rarity) : base(name, rarity, NUMBER_OF_SOCKETS, MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}