using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            //var context = new SoftUniContext();

            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.OrderBy(x => x.EmployeeId);

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.Salary > 50000).OrderBy(x => x.FirstName);

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees.Where(x => x.Department.Name == "Research and Development")
                    .OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName)
                    .Select(x => new { x.FirstName, x.LastName, DepartmentName = x.Department.Name, x.Salary });

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - ${employee.Salary:F2}");
            }

            return stringBuilder.ToString().Trim();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            
            var address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(address);

            context.SaveChanges();

            var employee = context.Employees.Where(x => x.LastName == "Nakov").First();
            var addressId = context.Addresses.Where(x => x == address).Select(x => x.AddressId).First();

            employee.Address = address;
            employee.AddressId = addressId;
            context.SaveChanges();

            var employees = context.Employees.OrderByDescending(x => x.AddressId).Take(10).Select(x => x.Address.AddressText).ToArray();

            foreach (var e in employees)
            {
                sb.AppendLine(e);
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var ees = context.Employees.Where(x => x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId)
                .Select(y => y.Project.StartDate).Where(y => y.Year == 2001 || y.Year == 2002 || y.Year == 2003).Any())
                    .Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        ManagerFirstName = x.Manager.FirstName,
                        ManagerLastName = x.Manager.LastName,
                        Projects = x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId).Select(y => y.Project)
                        .Where(y => y.StartDate.Year == 2001 || y.StartDate.Year == 2002 || y.StartDate.Year == 2003)
                    .Select(y => new { y.Name, y.StartDate, y.EndDate }).ToArray()
                    }).Take(30);

            foreach (var e in ees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");
                foreach (var p in e.Projects)
                {
                    string formattedStartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    string formattedEndDate = p.EndDate.HasValue
                        ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                        : "not finished";

                    sb.AppendLine($"--{p.Name} - {formattedStartDate} - {formattedEndDate}");
                }
            }

            return sb.ToString().Trim();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses.OrderByDescending(x => x.Employees.Count())
                    .ThenBy(x => x.Town.Name).ThenBy(x => x.AddressText)
                    .Select(x => new
                    {
                        AddresText = x.AddressText,
                        TownName = x.Town.Name,
                        EmployeeCount = x.Employees.Count()
                    }).Take(10).ToArray();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.AddresText}, {address.TownName} - {address.EmployeeCount} employees");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees.Where(x => x.EmployeeId == 147)
                    .Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        x.JobTitle,
                        Projects =
                    x.EmployeesProjects.Where(y => y.EmployeeId == x.EmployeeId).Select(y => new { y.Project.Name })
                    .OrderBy(y => y.Name).ToArray()
                    }).First();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in employee.Projects)
            {
                sb.AppendLine($"{project.Name}");
            }

            return sb.ToString().Trim();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context.Departments.Where(x => x.Employees.Count() > 5).OrderBy(x => x.Employees.Count()).ThenBy(x => x.Name)
                    .Select(x => new
                    {
                        x.Name,
                        ManagerFirstName = x.Manager.FirstName,
                        ManagerLastName = x.Manager.LastName,
                        Employees = x.Employees.Select(y => new { y.FirstName, y.LastName, y.JobTitle })
                        .OrderBy(y => y.FirstName).ThenBy(y => y.LastName).ToArray()
                    });

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.Name} - {department.ManagerFirstName} {department.ManagerLastName}");

                foreach (var e in department.Employees)
                {
                    sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }

                sb.AppendLine("----------");
            }

            return sb.ToString().Trim();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).OrderBy(x => x.Name);

            foreach (var project in projects)
            {
                sb.AppendLine($"{project.Name}");
                sb.AppendLine(project.Description);
                sb.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return sb.ToString().Trim();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.Department.Name == "Engineering" ||
                x.Department.Name == "Tool Design" || x.Department.Name == "Marketing" || x.Department.Name == "Information Services")
                    .OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;

                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F2})");
            }

            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.FirstName.StartsWith("Sa")).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
            }

            return sb.ToString().Trim();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var project = context.Projects.Where(x => x.ProjectId == 2).First();

            context.EmployeesProjects.RemoveRange(context.EmployeesProjects.Where(x => x.ProjectId == 2));
            context.Projects.Remove(project);
            context.SaveChanges();

            var projects = context.Projects.Take(10);

            foreach (var p in projects)
            {
                sb.AppendLine(p.Name);
            }

            return sb.ToString().Trim();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            string townName = "Seattle";

            var town = context.Towns.Where(x => x.Name == townName).First();

            int count = context.Addresses.Where(x => x.Town.Name == townName).Count();

            var employees = context.Employees.Where(x => x.Address.Town.Name == townName).ToList();

            foreach (var employee in employees)
            {
                employee.Address = null;
                employee.AddressId = null;
            }

            context.Addresses.RemoveRange(context.Addresses.Where(x => x.Town.Name == townName));
            context.Towns.Remove(town);

            context.SaveChanges();

            string wasWere = count == 1 ? "was" : "were";

            sb.AppendLine($"{count} addresses in {townName} {wasWere} deleted");

            return sb.ToString().Trim();
        }

        public static void Main(string[] args)
        {
            

            var context = new SoftUniContext();

            using (context)
            {
                //Employees Full Information 
                //Console.WriteLine(GetEmployeesFullInformation(context));

                //Employees with Salary Over 50 000
                //Console.WriteLine(GetEmployeesWithSalaryOver50000(context));

                //Employees from Research and Development
                //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));

                //Adding a New Address and Updating Employee
                //Console.WriteLine(AddNewAddressToEmployee(context));

                //Employees and Projects
                //Console.WriteLine(GetEmployeesInPeriod(context));

                //Addresses by Town
                //Console.WriteLine(GetAddressesByTown(context));

                //Employee 147
                //Console.WriteLine(GetEmployee147(context));

                //Departments with More Than 5 Employees
                //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));

                //Find Latest 10 Projects
                //Console.WriteLine(GetLatestProjects(context));

                //Increase Salaries
                //Console.WriteLine(IncreaseSalaries(context));

                //Find Employees by First Name Starting With "Sa"
                //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));

                //Delete Project by Id
                //Console.WriteLine(DeleteProjectById(context));

                //Remove Towns
                Console.WriteLine(RemoveTown(context));
            }
        }
    }
}
