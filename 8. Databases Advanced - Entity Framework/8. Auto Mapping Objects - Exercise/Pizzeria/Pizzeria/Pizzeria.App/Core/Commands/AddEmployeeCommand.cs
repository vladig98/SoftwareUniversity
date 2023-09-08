using Pizzeria.App.Core.Contracts;
using Pizzeria.App.Core.Dtos;

namespace Pizzeria.App.Core.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly IEmployeeController controller;

        public AddEmployeeCommand(IEmployeeController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            string firstName = args[0];
            string lastName = args[1];
            decimal salary = decimal.Parse(args[2]);

            EmployeeDto employeeDto = new EmployeeDto()
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            };

            controller.AddEmployee(employeeDto);

            return $"Employee {firstName} {lastName} added successfully.";
        }
    }
}
