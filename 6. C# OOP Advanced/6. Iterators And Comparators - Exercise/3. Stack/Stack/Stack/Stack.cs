using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> Collection { get; set; }

        public Stack()
        {
            Collection = new List<T>();
        }

        public void Push(List<T> elements)
        {
            Collection.AddRange(elements);
        }

        public T Pop()
        {
            if (Collection.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }

            T element = Collection.Last();
            Collection.RemoveAt(Collection.Count - 1);
            return element;
        }

        private IEnumerable<T> List()
        {
            for (int i = Collection.Count - 1; i >= 0; i--)
            {
                yield return Collection[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return List().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
