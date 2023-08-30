using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                double salary = double.Parse(inputTokens[1]);
                string position = inputTokens[2];
                string department = inputTokens[3];
                string email = null;
                int? age = null;

                if (inputTokens.Length > 4)
                {
                    if (Regex.IsMatch(inputTokens[4], @"\d+"))
                    {
                        age = int.Parse(inputTokens[4]);
                    }
                    else
                    {
                        email = inputTokens[4];
                    }
                }
                if (inputTokens.Length > 5)
                {
                    age = int.Parse(inputTokens[5]);
                }

                Employee employee = new Employee(name, salary, position, department, email == null ? @"n/a" : email, age == null ? -1 : (int)age);
                employees.Add(employee);
            }

            string highestPaidDepartment = employees
                                            .GroupBy(x => x.Department, x => x.Salary, (department, salary) => new { Key = department, Average = salary.Average() })
                                            .ToList()
                                            .OrderByDescending(x => x.Average)
                                            .FirstOrDefault().Key;

            Console.WriteLine("Highest Average Salary: {0}", highestPaidDepartment);

            employees = employees.Where(x => x.Department == highestPaidDepartment).OrderByDescending(x => x.Salary).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
