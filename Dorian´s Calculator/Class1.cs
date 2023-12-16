
using System.Runtime.CompilerServices;

namespace Dorian_s_Calculator
{
    public class Calculator
    {

        private string _lastOperation;
        private double _lastResult;
        private string _name;

        public Calculator(string name)
        {
            _name = name;
        }
        public double Sum(double number1, double number2)
        {
            _lastOperation = "Sum";
            _lastResult = number1 + number2;
            return _lastResult;
        }

        public double Subtract(double number1, double number2)
        {
            _lastOperation = "Subtract";
            _lastResult = number1 - number2;
            return _lastResult;
        }

        public double Multiply(double number1, double number2)
        {
            _lastOperation = "Multiply";
            _lastResult = number1 * number2;
            return _lastResult;
        }

        public double Divide(double dividend, double divisor)
        {
            _lastOperation = "Divide";
            _lastResult = dividend / divisor;
            return _lastResult;
        }

        public double GetLastResult()
        {
            return _lastResult;
        }
        public string GetLastOperation()
        {
            return _lastOperation;
        }

    }
        
    
}
