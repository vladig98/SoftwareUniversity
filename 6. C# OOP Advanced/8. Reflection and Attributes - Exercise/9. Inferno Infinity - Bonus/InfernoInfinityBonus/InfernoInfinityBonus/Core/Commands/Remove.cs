using InfernoInfinityBonus.Contracts;

namespace InfernoInfinityBonus.Core.Commands
{
    public class Remove : Command
    {
        [Inject]
        IRepository WeaponRepository;

        public Remove(string[] data, IRepository weaponRepository) : base(data)
        {
            WeaponRepository = weaponRepository;
        }

        public override void Execute()
        {
            WeaponRepository.RemoveGem(Data[1], int.Parse(Data[2]));
        }
    }
}
