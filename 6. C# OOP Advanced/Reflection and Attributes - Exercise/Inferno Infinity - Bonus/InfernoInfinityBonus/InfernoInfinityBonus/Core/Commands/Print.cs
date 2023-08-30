using InfernoInfinityBonus.Contracts;

namespace InfernoInfinityBonus.Core.Commands
{
    public class Print : Command
    {
        [Inject]
        IRepository WeaponRepository;

        public Print(string[] data, IRepository weaponRepository):base(data)
        {
            WeaponRepository = weaponRepository;
        }

        public override void Execute()
        {
            WeaponRepository.Print(Data[1]);
        }
    }
}
