﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class AdditionStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}