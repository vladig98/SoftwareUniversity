using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;
        public int Count => list.Count();

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T element = list.Last();
            list.RemoveAt(Count - 1);
            return element;
        }

        public Box()
        {
            list = new List<T>();
        }
    }
}
