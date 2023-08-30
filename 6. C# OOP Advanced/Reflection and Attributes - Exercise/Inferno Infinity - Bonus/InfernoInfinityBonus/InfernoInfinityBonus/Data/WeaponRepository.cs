using InfernoInfinityBonus.Contracts;
using InfernoInfinityBonus.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace InfernoInfinityBonus.Data
{
    public class WeaponRepository : IRepository
    {
        private List<IWeapon> Weapons;

        public WeaponRepository()
        {
            Weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            Weapons.Add(weapon);
        }

        public void AddGem(string weaponName, int socketIndex, string gemType)
        {
            IWeapon weapon = Weapons.Where(x => x.Name == weaponName).FirstOrDefault();
            weapon.AddGem(socketIndex, gemType);
        }

        public void RemoveGem(string weaponName, int socketIndex)
        {
            IWeapon weapon = Weapons.Where(x => x.Name == weaponName).FirstOrDefault();
            weapon.RemoveGem(socketIndex);
        }

        public void Print(string weaponName)
        {
            IWeapon weapon = Weapons.Where(x => x.Name == weaponName).FirstOrDefault();
            weapon.UpdateStats();
            OutputWriter.WriteLine(weapon.ToString());
        }
    }
}
