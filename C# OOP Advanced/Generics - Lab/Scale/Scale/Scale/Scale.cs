using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class Scale<T> where T : IComparable<T>
    {
        private T Left { get; set; }
        private T Right { get; set; }

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T GetHeavier()
        {
            if (Right.CompareTo(Left) > 0)
            {
                return Right;
            }

            if (Right.CompareTo(Left) < 0)
            {
                return Left;
            }

            return default(T);
        }
    }
}
