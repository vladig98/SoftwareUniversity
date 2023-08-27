using InfernoInfinityBonus.Contracts;

namespace InfernoInfinityBonus.Core.Commands
{
    public class Add : Command
    {
        [Inject]
        IRepository WeaponRepository;

        public Add(string[] data, IRepository weaponRepository):base(data)
        {
            WeaponRepository = weaponRepository;
        }

        public override void Execute()
        {
            WeaponRepository.AddGem(Data[1], int.Parse(Data[2]), Data[3]);
        }
    }
}
