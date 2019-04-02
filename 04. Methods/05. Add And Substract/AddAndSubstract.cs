using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Add_And_Substract
{
    class AddAndSubstract
    {
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        static int Subtractt(int result1, int third)
        {
            int result2 = result1 - third;
            return result2;
        }

        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result1 = Sum(firstNum, secondNum);
            int result2 = Subtractt(result1, thirdNum);

            Console.WriteLine(result2);
        }
    }
}
