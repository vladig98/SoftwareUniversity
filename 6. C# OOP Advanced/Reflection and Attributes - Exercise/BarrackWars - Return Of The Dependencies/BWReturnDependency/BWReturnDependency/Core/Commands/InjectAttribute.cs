using System;
using System.Collections.Generic;
using System.Text;

namespace BWReturnDependency.Core.Commands
{
    [AttributeUsage(AttributeTargets.Field)]
    public class InjectAttribute : Attribute
    {
    }
}
