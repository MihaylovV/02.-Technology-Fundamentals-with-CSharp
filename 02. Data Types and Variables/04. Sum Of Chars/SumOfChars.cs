using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Of_Chars
{
    class SumOfChars
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());

                int charValue = (int)character;

                sumOfDigits += charValue;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
