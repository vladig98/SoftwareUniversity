using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public interface IAbs
    {
        decimal Abs(decimal value);
        double Abs(double value);
        short Abs(short value);
        int Abs(int value);
        long Abs(long value);
        sbyte Abs(sbyte value);
        float Abs(float value);
    }
}
