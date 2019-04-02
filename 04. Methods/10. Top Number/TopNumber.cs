using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Top_Number
{
    class TopNumber
    {
        static bool IsTopNumber(string input)
        {
            bool isTop;
            int sum = 0;
            int countOdd = 0;

            char[] charArray = input.ToCharArray();
            int[] numArray = new int[charArray.Length];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(charArray[i].ToString());
                sum += numArray[i];
                if (numArray[i] % 2 != 0)
                {
                    countOdd++;
                }
            }

            if (sum % 8 == 0 && countOdd >= 1)
            {
                isTop = true;
            }
            else
            {
                isTop = false;
            }
            return isTop;
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string currentNumber = i.ToString();
                bool toPrint = IsTopNumber(currentNumber);
                if (toPrint == true)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }
    }
}
