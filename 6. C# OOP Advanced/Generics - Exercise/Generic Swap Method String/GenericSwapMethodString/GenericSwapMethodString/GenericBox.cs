using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericSwapMethodString
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
