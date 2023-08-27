using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomListSorter
{
    public class GenericList<T> where T : IComparable<T>
    {
        public List<T> Elements { get; private set; }

        public void Add(T element)
        {
            Elements.Add(element);
        }

        public T Remove(int index)
        {
            T element = Elements[index];
            Elements.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return Elements.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T element1 = Elements[index1];
            T element2 = Elements[index2];

            Elements.RemoveAt(index1);
            Elements.Insert(index1, element2);
            Elements.RemoveAt(index2);
            Elements.Insert(index2, element1);
        }

        public int CountGreaterThan(T element)
        {
            return Elements.Where(x => x.CompareTo(element) > 0).Count();
        }

        public T Min()
        {
            return Elements.Min();
        }

        public T Max()
        {
            return Elements.Max();
        }

        public GenericList()
        {
            Elements = new List<T>();
        }
    }
}
