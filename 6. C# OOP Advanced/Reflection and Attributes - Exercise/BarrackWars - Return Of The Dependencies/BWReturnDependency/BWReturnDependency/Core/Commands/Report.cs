using BWReturnDependency.Contracts;

namespace BWReturnDependency.Core.Commands
{
    public class Report : Command
    {
        [Inject]
        IRepository repository;

        protected Report(string[] data, IRepository repository) : base(data)
        {
            this.repository = repository;
        }

        public override string Execute()
        {
            string output = repository.Statistics;
            return output;
        }
    }
}
