using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Digits
{
    class SumDigits
    {
        static int sumDigits(int number)
        {
            List<int> digitsList = new List<int>();
            while (number > 0)
            {
                digitsList.Add(number % 10);
                number = number / 10;
            }

            int sumDigits = 0;
            foreach (int num in digitsList)
            {
                sumDigits += num;
            }
            return sumDigits;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = sumDigits(number);
            Console.WriteLine(result);
        }
    }
}
