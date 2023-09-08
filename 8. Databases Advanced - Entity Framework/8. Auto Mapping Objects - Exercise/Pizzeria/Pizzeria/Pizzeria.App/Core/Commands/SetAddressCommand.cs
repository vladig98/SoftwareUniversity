using Pizzeria.App.Core.Contracts;

namespace Pizzeria.App.Core.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly IEmployeeController controller;

        public SetAddressCommand(IEmployeeController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            string address = args[1];

            controller.SetAddress(id, address);

            return "Command accomplished successfully";
        }
    }
}
