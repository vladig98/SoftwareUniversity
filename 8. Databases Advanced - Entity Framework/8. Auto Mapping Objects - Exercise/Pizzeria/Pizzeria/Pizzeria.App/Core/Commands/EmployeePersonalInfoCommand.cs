using Pizzeria.App.Core.Contracts;

namespace Pizzeria.App.Core.Commands
{
    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeController controller;

        public EmployeePersonalInfoCommand(IEmployeeController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);

            var employeePersonalInfoDto = controller.GetEmployeePersonalInfo(id);

            return $"ID: {employeePersonalInfoDto.Id} - " +
                $"{employeePersonalInfoDto.FirstName} {employeePersonalInfoDto.LastName} - " +
                $"${employeePersonalInfoDto.Salary}\r\nBirthday: {employeePersonalInfoDto.BirthDate.Value.ToString("dd-MM-yyyy")}" +
                $"\r\nAddress: {employeePersonalInfoDto.Address}\r\n";
        }
    }
}
