using AutoMapper;
using AutoMapper.QueryableExtensions;
using Pizzeria.App.Core.Contracts;
using Pizzeria.App.Core.Dtos;
using Pizzeria.Data;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizzeria.App.Core.Controllers
{
    public class EmployeeController : IEmployeeController
    {
        private readonly PizzeriaContext context;
        private readonly IMapper mapper;

        public EmployeeController(PizzeriaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employee>(employeeDto);

            context.Employees.Add(employee);

            context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            var employee = context.Employees.Where(x => x.Id == employeeId).ProjectTo<EmployeeDto>().SingleOrDefault();

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            return employee;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            var employee = context.Employees.Where(x => x.Id == employeeId).ProjectTo<EmployeePersonalInfoDto>().SingleOrDefault();

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            return employee;
        }

        public ICollection<ListEmployeeDto> ListEmployeesOlderThan(int age)
        {
            var employees = context.Employees.ToList().Where(x => x.BirthDate.HasValue)
                .Where(x => (int)(DateTime.Now.Subtract(x.BirthDate.Value).TotalDays / 365) > age)
                .OrderByDescending(x => x.Salary)
                .ToList();

            List<ListEmployeeDto> employeeDtos = new List<ListEmployeeDto>();

            foreach (var employee in employees)
            {
                employeeDtos.Add(mapper.Map<ListEmployeeDto>(employee));
            }

            if (employeeDtos.Count == 0)
            {
                throw new ArgumentException("Fuck off");
            }

            return employeeDtos;
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            employee.Address = address;

            context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            employee.BirthDate = date;

            context.SaveChanges();
        }
    }
}
