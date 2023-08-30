using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T, J>
    {
        public T Item1 { get; set; }
        public J Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }

        public Tuple(T item1, J item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
