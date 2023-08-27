using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            return Enumerable.Repeat(item, length).ToArray();
        }
    }
}
