﻿namespace InfernoInfinityBonus.Contracts
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string weaponType, string weaponName, string weaponRarity);
    }
}
