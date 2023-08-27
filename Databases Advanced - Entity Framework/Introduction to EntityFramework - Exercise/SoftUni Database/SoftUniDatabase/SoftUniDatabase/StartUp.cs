using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P02_DatabaseFirst
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Employees Full Information 

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employees = context.Employees.OrderBy(x => x.EmployeeId);

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            //    }
            //}

            //Employees with Salary Over 50 000

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employees = context.Employees.Where(x => x.Salary > 50000).OrderBy(x => x.FirstName);

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine(employee.FirstName);
            //    }
            //}

            //Employees from Research and Development

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employees = context.Employees.Where(x => x.Department.Name == "Research and Development")
            //        .OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName)
            //        .Select(x => new { x.FirstName, x.LastName, DepartmentName = x.Department.Name, x.Salary });

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - ${employee.Salary:F2}");
            //    }
            //}

            //Adding a New Address and Updating Employee

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var address = new Address
            //    {
            //        AddressText = "Vitoshka 15",
            //        TownId = 4
            //    };

            //    context.Addresses.Add(address);

            //    context.SaveChanges();

            //    var employee = context.Employees.Where(x => x.LastName == "Nakov").First();
            //    var addressId = context.Addresses.Where(x => x == address).Select(x => x.AddressId).First();

            //    employee.Address = address;
            //    employee.AddressId = addressId;
            //    context.SaveChanges();

            //    var employees = context.Employees.OrderByDescending(x => x.AddressId).Take(10).Select(x => x.Address.AddressText).ToArray();

            //    foreach (var e in employees)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            //Employees and Projects

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var projects = context.Projects.Where(x => x.StartDate.Year == 2001 ||
            //    x.StartDate.Year == 2002 || x.StartDate.Year == 2003).ToArray();

            //    var employeeProjects = context.EmployeesProjects.Where(x => projects.Select(y => y.ProjectId).Contains(x.ProjectId)).ToArray();

            //    var employees = context.Employees.Where(x => employeeProjects.Select(y => y.EmployeeId).Contains(x.EmployeeId)).Take(30)
            //        .Select(x => new { x.EmployeeId, x.FirstName, x.LastName, 
            //            ManagerFirstName = x.Manager.FirstName, ManagerLastName = x.Manager.LastName });

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} " +
            //            $"- Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

            //        var ep = employeeProjects.Where(x => x.EmployeeId == employee.EmployeeId).Select(x => x.ProjectId).ToList();
            //        var p = projects.Where(x => ep.Contains(x.ProjectId)).ToList();

            //        foreach (var item in p)
            //        {
            //            string formattedStartDate = item.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //            string formattedEndDate = item.EndDate.HasValue 
            //                ? item.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) 
            //                : "not finished";

            //            Console.WriteLine($"--{item.Name} - {formattedStartDate} - {formattedEndDate}");
            //        }
            //    }
            //}

            //Addresses by Town

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var addresses = context.Addresses.OrderByDescending(x => x.Employees.Count())
            //        .ThenBy(x => x.Town.Name).ThenBy(x => x.AddressText)
            //        .Select(x => new
            //        {
            //            AddresText = x.AddressText,
            //            TownName = x.Town.Name,
            //            EmployeeCount = x.Employees.Count()
            //        }).Take(10).ToArray();

            //    foreach (var address in addresses)
            //    {
            //        Console.WriteLine($"{address.AddresText}, {address.TownName} - {address.EmployeeCount} employees");
            //    }
            //}
        }
    }
}
