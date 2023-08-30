using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomListIterator
{
    public class GenericList<T> where T : IComparable<T>
    {
        public IEnumerable<T> Elements { get; private set; }

        public void Add(T element)
        {
            ((List<T>)(Elements)).Add(element);
        }

        public T Remove(int index)
        {
            T element = ((List<T>)(Elements))[index];
            ((List<T>)(Elements)).RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return ((List<T>)(Elements)).Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T element1 = ((List<T>)(Elements))[index1];
            T element2 = ((List<T>)(Elements))[index2];

            ((List<T>)(Elements)).RemoveAt(index1);
            ((List<T>)(Elements)).Insert(index1, element2);
            ((List<T>)(Elements)).RemoveAt(index2);
            ((List<T>)(Elements)).Insert(index2, element1);
        }

        public int CountGreaterThan(T element)
        {
            return ((List<T>)(Elements)).Where(x => x.CompareTo(element) > 0).Count();
        }

        public T Min()
        {
            return ((List<T>)(Elements)).Min();
        }

        public T Max()
        {
            return ((List<T>)(Elements)).Max();
        }

        public GenericList()
        {
            Elements = new List<T>();
        }
    }
}
