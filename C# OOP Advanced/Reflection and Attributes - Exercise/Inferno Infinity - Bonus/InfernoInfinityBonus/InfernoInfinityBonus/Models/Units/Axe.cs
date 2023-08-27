namespace InfernoInfinityBonus.Models.Units
{
    public class Axe : Weapon
    {
        private const int NUMBER_OF_SOCKETS = 4;
        private const int MIN_DAMAGE = 5;
        private const int MAX_DAMAGE = 10;

        public Axe(string name, string rarity):base(name, rarity, NUMBER_OF_SOCKETS, MIN_DAMAGE, MAX_DAMAGE)
        {
        }
    }
}
