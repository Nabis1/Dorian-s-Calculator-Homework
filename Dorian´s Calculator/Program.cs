using System.Security.Cryptography.X509Certificates;

namespace Dorian_s_Calculator
{
     class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator("My Calculator");

            double sumResult = myCalculator.Sum(6, 9);
            Console.WriteLine($"Addition result: {sumResult}");

            double subtractResult = myCalculator.Subtract(10, 6);
            Console.WriteLine($"Substraction result: {subtractResult}");

            double multiplyResult = myCalculator.Multiply(7, 7);
            Console.WriteLine($"Multiply result: {multiplyResult}");

            double divideResult = myCalculator.Divide(8, 2);
            Console.WriteLine($"Division result: {divideResult}");

            string lastOperation = myCalculator.GetLastOperation();
            double lastResult = myCalculator.GetLastResult();
            Console.WriteLine($"Last operation performed: {lastOperation}");
            Console.WriteLine($"Last result: {lastResult}");
        }
    }
}
