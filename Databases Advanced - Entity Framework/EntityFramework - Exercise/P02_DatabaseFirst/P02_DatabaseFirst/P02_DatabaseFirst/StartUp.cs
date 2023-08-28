using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P02_DatabaseFirst
{
    internal class StartUp
    {
        static void Main(string[] args)
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
            //    var ees = context.Employees.Where(x => x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId)
            //    .Select(y => y.Project.StartDate).Where(y => y.Year == 2001 || y.Year == 2002 || y.Year == 2003).Any())
            //        .Select(x => new
            //        {
            //            x.FirstName,
            //            x.LastName,
            //            ManagerFirstName = x.Manager.FirstName,
            //            ManagerLastName = x.Manager.LastName,
            //            Projects = x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId).Select(y => y.Project)
            //            .Where(y => y.StartDate.Year == 2001 || y.StartDate.Year == 2002 || y.StartDate.Year == 2003)
            //        .Select(y => new { y.Name, y.StartDate, y.EndDate }).ToArray()
            //        }).Take(30);

            //    foreach (var e in ees)
            //    {
            //        Console.WriteLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");
            //        foreach (var p in e.Projects)
            //        {
            //            string formattedStartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //            string formattedEndDate = p.EndDate.HasValue
            //                ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
            //                : "not finished";

            //            Console.WriteLine($"--{p.Name} - {formattedStartDate} - {formattedEndDate}");
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

            //Employee 147

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employee = context.Employees.Where(x => x.EmployeeId == 147)
            //        .Select(x => new
            //        {
            //            x.FirstName,
            //            x.LastName,
            //            x.JobTitle,
            //            Projects =
            //        x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId).Select(y => new { y.Project.Name })
            //        .OrderBy(y => y.Name).ToArray()
            //        }).First();

            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            //    foreach (var project in employee.Projects)
            //    {
            //        Console.WriteLine($"{project.Name}");
            //    }
            //}

            //Departments with More Than 5 Employees

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var departments = context.Departments.Where(x => x.Employees.Count() > 5).OrderBy(x => x.Employees.Count()).ThenBy(x => x.Name)
            //        .Select(x => new { x.Name, ManagerFirstName = x.Manager.FirstName, ManagerLastName = x.Manager.LastName, 
            //            Employees = x.Employees.Select(y => new { y.FirstName, y.LastName, y.JobTitle })
            //            .OrderBy(y => y.FirstName).ThenBy(y => y.LastName).ToArray() });

            //    foreach (var department in departments)
            //    {
            //        Console.WriteLine($"{department.Name} - {department.ManagerFirstName} {department.ManagerLastName}");

            //        foreach (var e in department.Employees)
            //        {
            //            Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
            //        }

            //        Console.WriteLine("----------");
            //    }
            //}

            //Find Latest 10 Projects

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).OrderBy(x => x.Name);

            //    foreach (var project in projects)
            //    {
            //        Console.WriteLine($"{project.Name}");
            //        Console.WriteLine(project.Description);
            //        Console.WriteLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            //    }
            //}

            //Increase Salaries

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employees = context.Employees.Where(x => x.Department.Name == "Engineering" ||
            //    x.Department.Name == "Tool Design" || x.Department.Name == "Marketing" || x.Department.Name == "Information Services")
            //        .OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            //    foreach (var employee in employees)
            //    {
            //        employee.Salary *= 1.12M;

            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F2})");
            //    }

            //    context.SaveChanges();
            //}

            //Find Employees by First Name Starting With "Sa"

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var employees = context.Employees.Where(x => x.FirstName.StartsWith("Sa")).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
            //    }
            //}

            //Delete Project by Id

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var project = context.Projects.Where(x => x.ProjectId == 2).First();

            //    context.EmployeesProjects.RemoveRange(context.EmployeesProjects.Where(x => x.ProjectId == 2));
            //    context.Projects.Remove(project);
            //    context.SaveChanges();

            //    var projects = context.Projects.Take(10);

            //    foreach (var p in projects)
            //    {
            //        Console.WriteLine(p.Name);
            //    }
            //}

            //Remove Towns

            //string townName = Console.ReadLine();

            //var context = new SoftUniContext();

            //using (context)
            //{
            //    var town = context.Towns.Where(x => x.Name == townName).First();

            //    int count = context.Addresses.Where(x => x.Town.Name == townName).Count();

            //    var employees = context.Employees.Where(x => x.Address.Town.Name == townName).ToList();

            //    foreach (var employee in employees)
            //    {
            //        employee.Address = null;
            //        employee.AddressId = null;
            //    }

            //    context.Addresses.RemoveRange(context.Addresses.Where(x => x.Town.Name == townName));
            //    context.Towns.Remove(town);

            //    context.SaveChanges();

            //    string wasWere = count == 1 ? "was" : "were";

            //    Console.WriteLine($"{count} addresses in {townName} {wasWere} deleted");
            //}
        }
    }
}
