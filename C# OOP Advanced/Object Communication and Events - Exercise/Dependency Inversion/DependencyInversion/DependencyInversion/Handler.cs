using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Handler
    {
        public int OnCalculatorCalculate(object sender, CalculateEventArgs e)
        {
            switch (e.Strategy)
            {
                case StrategyEnum.ADDITION:
                    return e.FirstNumber + e.SecondNumber;
                case StrategyEnum.SUBTRACTION:
                    return e.FirstNumber - e.SecondNumber;
                case StrategyEnum.MULTIPLICATION:
                    return e.FirstNumber * e.SecondNumber;
                case StrategyEnum.DIVISION:
                    return e.FirstNumber / e.SecondNumber;
            }

            return 0;
        }
    }
}
