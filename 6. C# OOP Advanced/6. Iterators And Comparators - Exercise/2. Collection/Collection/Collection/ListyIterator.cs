using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IList<T> Collection { get; set; }
        private int Index;

        public ListyIterator(IList<T> collection)
        {
            Collection = new List<T>(collection);
            Index = 0;
        }

        public bool Move()
        {
            if (Index + 1 < Collection.Count)
            {
                Index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return Index < Collection.Count - 1;
        }

        public void Print()
        {
            if (Collection.Count == 0)
            {
                //throw new InvalidOperationException("Invalid Operation!");
                Console.WriteLine("Invalid Operation!");
                return;
            }

            Console.WriteLine(Collection[Index]);
        }

        private IEnumerable<T> List()
        {
            foreach (T item in Collection)
            {
                yield return item;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", List()));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return List().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
