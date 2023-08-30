using InfernoInfinityBonus.Contracts;
using System;
using System.Reflection;

namespace InfernoInfinityBonus.Core.Factories
{
    internal class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string weaponName, string weaponRarity)
        {
            Type classType = Type.GetType("InfernoInfinityBonus.Models.Units." + weaponType);

            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;
            object weapon = Activator.CreateInstance(classType, flags, null, new object[] { weaponName, weaponRarity }, null, null);

            return (IWeapon)weapon;
        }
    }
}
