using BWReturnDependency.Contracts;

namespace BWReturnDependency.Core.Commands
{
    public class Add : Command
    {
        [Inject]
        IRepository repository;
        [Inject]
        IUnitFactory unitFactory;

        protected Add(string[] data, IRepository repository, IUnitFactory unitFactory):base(data)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = unitFactory.CreateUnit(unitType);
            repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
