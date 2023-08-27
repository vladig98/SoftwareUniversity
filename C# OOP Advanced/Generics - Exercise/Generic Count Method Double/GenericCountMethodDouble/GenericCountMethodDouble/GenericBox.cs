using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class GenericBox<T> : IComparable<GenericBox<T>> where T : IComparable<T>
    {
        private T Value { get; set; }

        public GenericBox(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }

        public int CompareTo(GenericBox<T> box)
        {
            return this.Value.CompareTo(box.Value);
        }
    }
}
