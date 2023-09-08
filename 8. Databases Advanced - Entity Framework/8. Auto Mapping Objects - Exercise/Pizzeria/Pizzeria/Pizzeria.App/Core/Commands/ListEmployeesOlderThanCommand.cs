using Pizzeria.App.Core.Contracts;
using System.Text;

namespace Pizzeria.App.Core.Commands
{
    public class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly IEmployeeController controller;

        public ListEmployeesOlderThanCommand(IEmployeeController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            int age = int.Parse(args[0]);

            var employees = controller.ListEmployeesOlderThan(age);

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                var manager = employee.ManagerFirstName == null ? "[no manager]" : employee.ManagerFirstName + " " + employee.ManagerLastName;
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - ${employee.Salary:f2} - Manager: {manager}");
            }

            return sb.ToString();
        }
    }
}
