using Pizzeria.App.Core.Contracts;
using System.Text;

namespace Pizzeria.App.Core.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly IManagerController controller;

        public ManagerInfoCommand(IManagerController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);

            var managerDto = controller.GetManagerInfo(employeeId);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{managerDto.FirstName} {managerDto.LastName} | Employees: {managerDto.EmployeesDto.Count}");

            foreach (var employeeDto in managerDto.EmployeesDto)
            {
                sb.AppendLine($"    - {employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:f2}");
            }

            return sb.ToString();
        }
    }
}
