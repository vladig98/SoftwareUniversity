using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomClassAttribute
{
    public class Knife : IWeapon
    {
        private int MinDamage { get; set; }
        private int MaxDamage { get; set; }
        private int NumberOfSockets { get; set; }
        public string Name { get; set; }
        private RarityEnum Rarity { get; set; }
        private int Strength { get; set; }
        private int Agility { get; set; }
        private int Vitality { get; set; }
        private Gem[] Gems { get; set; }

        public Knife(string name, string rarity)
        {
            Name = name;
            NumberOfSockets = 2;
            Enum.TryParse(rarity, out RarityEnum value);
            Rarity = value;
            MinDamage = 3 * (int)value;
            MaxDamage = 4 * (int)value;
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
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * 7;
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count();
            Strength += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * 2;

            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * 2;
            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count() * 4;
            Agility += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * 8;

            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Ruby).Count() * 5;
            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Emerald).Count() * 9;
            Vitality += Gems.Where(x => x != null && x.GemType == GemEnum.Amethyst).Count() * 4;

            Strength += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);
            Agility += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);
            Vitality += Gems.Where(x => x != null).Sum(x => (int)x.Clarity);

            MinDamage += Strength * 2;
            MaxDamage += Strength * 3;

            MinDamage += Agility;
            MaxDamage += Agility * 4;
        }

        public override string ToString()
        {
            //UpdateStats();
            return $"{Name}: {MinDamage}-{MaxDamage} Damage, +{Strength} Strength, +{Agility} Agility, +{Vitality} Vitality";
        }
    }
}
