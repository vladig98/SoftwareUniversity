using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListSorter
{
    public static class Sorter<T> where T : IComparable<T>
    {
        public static void Sort(GenericList<T> list)
        {
            list.Elements.Sort();
        }
    }
}
