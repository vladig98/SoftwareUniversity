using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<T, J, K>
    {
        public T Item1 { get; set; }
        public J Item2 { get; set; }
        public K Item3 { get; set; }

        public Threeuple(T item1, J item2, K item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
