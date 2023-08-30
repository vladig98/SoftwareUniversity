namespace InfernoInfinityBonus.Contracts
{
    public interface IWeapon
    {
        string Name { get; set; }
        void AddGem(int index, string type);
        void RemoveGem(int index);
        void UpdateStats();
    }
}
