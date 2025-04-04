﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DetailPrinter
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
