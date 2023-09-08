using Pizzeria.App.Core.Dtos;
using System;
using System.Collections.Generic;

namespace Pizzeria.App.Core.Contracts
{
    public interface IEmployeeController
    {
        void AddEmployee(EmployeeDto employeeDto);

        void SetBirthday(int employeeId, DateTime date);

        void SetAddress(int employeeId, string address);

        EmployeeDto GetEmployeeInfo(int employeeId);

        EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId);

        ICollection<ListEmployeeDto> ListEmployeesOlderThan(int age);
    }
}
