using System.Collections.Generic;

namespace Pizzeria.App.Core.Dtos
{
    public class ManagerDto
    {
        public ManagerDto()
        {
            EmployeesDto = new HashSet<EmployeeDto>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<EmployeeDto> EmployeesDto { get; set; }
    }
}
