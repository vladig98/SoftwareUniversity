using System;
using System.Collections.Generic;

namespace DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        //public void PrintDetails()
        //{
        //    foreach (Employee employee in this.employees)
        //    {
        //        if (employee is Manager)
        //        {
        //            this.PrintManager((Manager)employee);
        //        }
        //        else
        //        {
        //            this.PrintEmployee(employee);
        //        }
        //    }
        //}

        public void PrintEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        //private void PrintEmployee(Employee employee)
        //{
        //    Console.WriteLine(employee.Name);
        //}

        //private void PrintManager(Manager manager)
        //{
        //    Console.WriteLine(manager.Name);
        //    Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        //}
    }
}
