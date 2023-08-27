using System;
using System.Collections.Generic;
using System.Text;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class SoftUniAttribute : Attribute
{
    public string Name { get; set; }

    public SoftUniAttribute(string name)
    {
        Name = name;
    }
}
