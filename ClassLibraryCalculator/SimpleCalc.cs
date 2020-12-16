using System;

namespace ClassLibraryCalculator
{
    public class SimpleCalc
    {

        public double AddNumbers(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }
        public double SubstractNumbers(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }
        public double MultiplyNumbers(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }
        public double DivideNumbers(double leftNumber, double rightNumber)
        {
            return leftNumber / rightNumber;
        }


        public double OpertorSwitch(string oper, double leftNumber, double rightNumber)
        {
            switch (oper)
            {
                case "add":
                    return AddNumbers(leftNumber, rightNumber);
                case "substract":
                    return SubstractNumbers(leftNumber, rightNumber);
                case "multiply":
                    return MultiplyNumbers(leftNumber, rightNumber);
                case "divide":
                    return DivideNumbers(leftNumber, rightNumber);
                default:
                    return 0.0;
            }

        }
    }
}
