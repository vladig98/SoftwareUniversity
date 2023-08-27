using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class CalculateEventArgs : EventArgs
    {
        public StrategyEnum Strategy;
        public int FirstNumber;
        public int SecondNumber;

        public CalculateEventArgs(StrategyEnum strategy, int firstNumber, int secondNumber)
        {
            Strategy = strategy;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
}
