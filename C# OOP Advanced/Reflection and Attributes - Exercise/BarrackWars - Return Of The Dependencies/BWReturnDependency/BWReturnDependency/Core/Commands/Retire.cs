using BWReturnDependency.Contracts;
using BWReturnDependency.Data;

namespace BWReturnDependency.Core.Commands
{
    public class Retire : Command
    {
        [Inject]
        IRepository repository;

        protected Retire(string[] data, IRepository repository) : base(data)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            string unitType = Data[1];
            string output = string.Empty;

            if (((UnitRepository)repository).DoesntHaveUnit(unitType))
            {
                output = "No such units in repository.";
            }
            else
            {
                repository.RemoveUnit(unitType);
                output = $"{unitType} retired!";
            }

            return output;
        }
    }
}
