using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CharMultiplier
{
    class CharMultiplier
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();

            string str1 = inputArray[0];
            string str2 = inputArray[1];

            double sum = 0;

            byte[] str1Values = Encoding.ASCII.GetBytes(str1);
            byte[] str2Values = Encoding.ASCII.GetBytes(str2);

            // GET LENGHT
            int maxLenght = 0;
            if (str1Values.Length >= str2Values.Length)
            {
                maxLenght = str1Values.Length;
            }
            else
            {
                maxLenght = str2Values.Length;
            }

            // SUM
            for (int i = 0; i < maxLenght; i++)
            {
                if (i < str1Values.Length && i < str2Values.Length)
                {
                    sum += str1Values[i] * str2Values[i];
                }
                else if (i < str1Values.Length && i >= str2Values.Length)
                {
                    sum += str1Values[i];
                }
                else if (i < str2Values.Length && i >= str1Values.Length)
                {
                    sum += str2Values[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
