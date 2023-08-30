using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> Books;

        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int CurrentIndex;
            private readonly List<Book> Books;

            public Book Current => Books[CurrentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            { }

            public bool MoveNext()
            {
                return ++CurrentIndex < Books.Count;
            }

            public void Reset()
            {
                CurrentIndex = -1;
            }

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                Books = new List<Book>(books);
            }
        }
    }
}
