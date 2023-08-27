using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public delegate int CalculateEventHandler(PrimitiveCalculator c, CalculateEventArgs eventArgs);

    public class PrimitiveCalculator
    {
        private bool isAddition;
        private AdditionStrategy additionStrategy;
        private SubtractionStrategy subtractionStrategy;

        public event CalculateEventHandler StrategyChange;
        private Handler handler;
        private StrategyEnum sign;

        public PrimitiveCalculator(Handler handler)
        {
            this.additionStrategy = new AdditionStrategy();
            this.subtractionStrategy = new SubtractionStrategy();
            this.isAddition = true;
            this.handler = handler;
        }

        public void changeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    sign = StrategyEnum.ADDITION;
                    break;
                case '-':
                    sign = StrategyEnum.SUBTRACTION;
                    break;
                 case '*':
                    sign = StrategyEnum.MULTIPLICATION;
                    break;
                case '/':
                    sign = StrategyEnum.DIVISION;
                    break;
            }
        }

        public int OnCalculate(CalculateEventArgs e)
        {
            return handler.OnCalculatorCalculate(this, e);
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            return OnCalculate(new CalculateEventArgs(sign, firstOperand, secondOperand));

            //if (this.isAddition)
            //{
            //    return additionStrategy.Calculate(firstOperand, secondOperand);
            //}
            //else
            //{
            //    return subtractionStrategy.Calculate(firstOperand, secondOperand);
            //}
        }
    }
}
