using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings
    {
        private List<string> data;

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            int index = data.Count - 1;
            string element = data.ElementAt(index);
            data.Remove(element);
            return element;
        }

        public string Peek()
        {
            int index = data.Count - 1;
            string element = data.ElementAt(index);
            return element;
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }

        public StackOfStrings()
        {
            data = new List<string>();
        }
    }
}
