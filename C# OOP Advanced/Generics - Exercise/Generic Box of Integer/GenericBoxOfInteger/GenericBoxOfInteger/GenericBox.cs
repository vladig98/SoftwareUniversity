using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class GenericBox<T>
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
    }
}
