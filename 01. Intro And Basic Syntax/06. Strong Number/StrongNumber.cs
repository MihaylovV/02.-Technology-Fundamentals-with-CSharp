using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strong_Number
{
    class StrongNumber
    {
        static double Factorial(double num)
        {
            double fact = num;
            for (double i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string numberString = number.ToString();
            double strongNumber = 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                double num = double.Parse(numberString[i].ToString());
                double factorialOfNum = Factorial(num);
                strongNumber += factorialOfNum;
            }

            if (strongNumber == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
