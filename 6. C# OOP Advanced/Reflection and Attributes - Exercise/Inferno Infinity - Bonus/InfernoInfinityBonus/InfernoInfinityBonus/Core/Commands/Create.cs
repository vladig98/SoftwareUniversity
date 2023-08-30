using InfernoInfinityBonus.Contracts;

namespace InfernoInfinityBonus.Core.Commands
{
    public class Create : Command
    {
        [Inject]
        IRepository WeaponRepository;
        [Inject]
        IWeaponFactory WeaponFactory;

        public Create(string[] data, IRepository weaponRepository, IWeaponFactory weaponFactory):base(data)
        {
            WeaponRepository = weaponRepository;
            WeaponFactory = weaponFactory;
        }

        public override void Execute()
        {
            string[] tokens = Data[1].Split(" ");

            string weaponName = Data[2];
            string weaponType = tokens[1];
            string weaponRarity = tokens[0];

            IWeapon weapon = WeaponFactory.CreateWeapon(weaponType, weaponName, weaponRarity);
            WeaponRepository.AddWeapon(weapon);
        }
    }
}
