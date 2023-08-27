using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace LinkedListTraversal
{
    public class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private System.Collections.Generic.LinkedList<T> Collection { get; set; }

        public int Count => Collection.Count;

        public void Add(T element)
        {
            Collection.AddLast(element);
        }

        public bool Remove(T element)
        {
            for (int i = 0; i < Collection.Count; i++)
            {
                if (Collection.ElementAt(i).CompareTo(element) == 0)
                {
                    Collection.Remove(element);
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public LinkedList()
        {
            Collection = new System.Collections.Generic.LinkedList<T>();
        }
    }
}
