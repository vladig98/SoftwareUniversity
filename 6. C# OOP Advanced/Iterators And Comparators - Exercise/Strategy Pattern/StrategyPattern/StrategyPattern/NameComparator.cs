using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StrategyPattern
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                result = y.Name[0].CompareTo(x.Name[0]);
            }

            return result;
        }
    }
}
