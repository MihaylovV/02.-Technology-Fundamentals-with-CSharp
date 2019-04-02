using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vowels_Count
{
    class VowelsCount
    {
        static void PrintNumberOfVowels(string input)
        {
            int count = 0;

            char[] vowels = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static void Main()
        {
            string input = Console.ReadLine();

            PrintNumberOfVowels(input);
        }
    }
}
