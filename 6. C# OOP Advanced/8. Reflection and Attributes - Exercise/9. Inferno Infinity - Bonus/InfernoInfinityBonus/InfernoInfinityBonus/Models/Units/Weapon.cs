using InfernoInfinityBonus.Contracts;
using InfernoInfinityBonus.Models.Enums;
using System;
using System.Linq;

namespace InfernoInfinityBonus.Models.Units
{
    public abstract class Weapon : IWeapon
    {
        private const int RUBY_STRENGTH = 7;
        private const int RUBY_AGILITY = 2;
        private const int RUBY_VITALITY = 5;

        private const int EMERALD_STRENGTH = 1;
        private const int EMERALD_AGILITY = 4;
        private const int EMERALD_VITALITY = 9;

        private const int AMETHYST_STRENGTH = 2;
        private const int AMETHYST_AGILITY = 8;
        private const int AMETHYST_VITALITY = 4;

        private const int STRENGTH_MIN_DAMAGE_BONUS = 2;
        private const int STRENGTH_MAX_DAMAGE_BONUS = 3;

        private const int AGILITY_MIN_DAMAGE_BONUS = 1;
        private const int AGILITY_MAX_DAMAGE_BONUS = 4;

        public string Name { get; set; }
        protected int MinDamage { get; set; }
        protected int MaxDamage { get; set; }
        protected int NumberOfSockets { get; set; }
        protected RarityEnum Rarity { get; set; }
        protected int Strength { get; set; }
        protected int Agility { get; set; }
        protected int Vitality { get; set; }
        protected Gem[] Gems { get; set; }

        public Weapon(string name, string rarity, int numberOfSockets, int minDamage, int maxDamage)
        {
            Name = name;
            NumberOfSockets = numberOfSockets;
            Enum.TryParse(rarity, out RarityEnum value);
            Rarity = value;
            MinDamage = minDamage * (int)value;
            MaxDamage = maxDamage * (int)value;
            Gems = new Gem[NumberOfSockets];
            Strength = 0;
            Agility = 0;
            Vitality = 0;
        }

        public void AddGem(int index, string type)
        {
            if (index < 0 || index >= NumberOfSockets)
            {
                return;
            }
            string[] tokens = type.Split(' ');
            Gem gem = new Gem(tokens[1], tokens[0]);
            Gems[index] = gem;
        }

        public void RemoveGem(int index)
        {
            if (index < 0 || index >= NumberOfSockets)
            {
                return;
            }
            Gems[index] = null;
        }

        public void UpdateStats()
        {
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * RUBY_STRENGTH;
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count() * EMERALD_STRENGTH;
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * AMETHYST_STRENGTH;

            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * RUBY_AGILITY;
            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count() * EMERALD_AGILITY;
            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * AMETHYST_AGILITY;

            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * RUBY_VITALITY;
            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count() * EMERALD_VITALITY;
            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * AMETHYST_VITALITY;

            Strength += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);
            Agility += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);
            Vitality += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);

            MinDamage += Strength * STRENGTH_MIN_DAMAGE_BONUS;
            MaxDamage += Strength * STRENGTH_MAX_DAMAGE_BONUS;

            MinDamage += Agility * AGILITY_MIN_DAMAGE_BONUS;
            MaxDamage += Agility * AGILITY_MAX_DAMAGE_BONUS;
        }

        public override string ToString()
        {
            return $"{Name}: {MinDamage}-{MaxDamage} Damage, +{Strength} Strength, +{Agility} Agility, +{Vitality} Vitality";
        }
    }
}
