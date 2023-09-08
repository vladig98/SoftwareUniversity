using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pizzeria.App.Core.Contracts;
using Pizzeria.App.Core.Dtos;
using Pizzeria.Data;
using System;
using System.Linq;

namespace Pizzeria.App.Core.Controllers
{
    public class ManagerController : IManagerController
    {
        private readonly PizzeriaContext context;

        public ManagerController(PizzeriaContext context)
        {
            this.context = context;
        }

        public ManagerDto GetManagerInfo(int employeeId)
        {
            var employee = context.Employees.Include(x => x.ManagerEmployees)
                .Where(x => x.Id == employeeId).ProjectTo<ManagerDto>().SingleOrDefault();

            if (employee == null)
            {
                throw new ArgumentException("Invalid id");
            }

            return employee;
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = context.Employees.Find(employeeId);
            var manager = context.Employees.Find(managerId);

            if (employee == null || manager == null)
            {
                throw new ArgumentException("Invalid id");
            }

            employee.Manager = manager;

            context.SaveChanges();
        }
    }
}
