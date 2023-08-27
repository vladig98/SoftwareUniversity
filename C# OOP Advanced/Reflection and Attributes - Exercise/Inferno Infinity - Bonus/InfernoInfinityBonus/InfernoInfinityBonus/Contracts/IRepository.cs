namespace InfernoInfinityBonus.Contracts
{
    public interface IRepository
    {
        void AddWeapon(IWeapon weapon);
        void AddGem(string weaponName, int socketIndex, string gemType);
        void RemoveGem(string weaponName, int socketIndex);
        void Print(string weaponName);
    }
}
