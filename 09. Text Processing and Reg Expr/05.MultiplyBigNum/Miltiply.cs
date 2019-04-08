using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MultiplyBigNum
{
    class Miltiply
    {
        static void Main()
        {
            string num1 = Console.ReadLine().TrimStart(new char[] { '0' });
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentMultiplication = 0;
            List<int> result = new List<int>();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int currentDigit = num1[i] - '0';
                currentMultiplication = currentDigit * num2;
                currentMultiplication += decimalReminder;
                result.Add(currentMultiplication % 10);
                decimalReminder = currentMultiplication / 10;
            }
            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
