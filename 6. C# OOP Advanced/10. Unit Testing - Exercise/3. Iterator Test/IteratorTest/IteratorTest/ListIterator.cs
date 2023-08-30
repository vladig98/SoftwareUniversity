using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorTest
{
    public class ListIterator
    {
        private List<string> Elements;
        private int Index;

        public ListIterator(List<string> elemnets)
        {
            if (elemnets == null)
            {
                throw new ArgumentNullException();
            }

            Elements = elemnets;

            Index = 0;
        }

        public bool Move()
        {
            if (Index < Elements.Count)
            {
                Index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return Index < Elements.Count - 1;
        }

        public void Print()
        {
            if (Elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(Elements[Index]);
        }
    }
}
