using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial_Divison
{
    class FactorialDivision
    {
        static double CalculateFactorial(double number)
        {
            double factorial = number;
            for (double i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double factorialFirst = CalculateFactorial(firstNumber);
            double factorialSecond = CalculateFactorial(secondNumber);

            double result = factorialFirst / factorialSecond;

            Console.WriteLine("{0:F2}", result);
        }
    }
}
