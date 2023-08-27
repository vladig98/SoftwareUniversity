using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    internal class Maths : IAbs, IFloor
    {
        private readonly IAbs abs;
        private readonly IFloor floor;

        public Maths(IAbs abs, IFloor floor)
        {
            this.abs = abs;
            this.floor = floor;
        }

        public decimal Abs(decimal value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public double Abs(double value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public short Abs(short value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public int Abs(int value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public long Abs(long value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public sbyte Abs(sbyte value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public float Abs(float value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }

        public decimal Floor(decimal d)
        {
            d = decimal.Parse(d.ToString().Split(new[] { '.', ','}, StringSplitOptions.RemoveEmptyEntries)[0]);
            return d;
        }

        public double Floor(double d)
        {
            d = double.Parse(d.ToString().Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            return d;
        }
    }
}
