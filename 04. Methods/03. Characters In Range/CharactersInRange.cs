using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Characters_In_Range
{
    class CharactersInRange
    {
        static void PrintTheBetweenChars(char first, char second)
        {
            List<char> charList = new List<char>();


            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write("{0} ", Convert.ToChar(i));
                }
                Console.WriteLine();
            }

            else
            {
                for (int i = first - 1; i > second; i--)
                {
                    charList.Add(Convert.ToChar(i));
                }
                Console.WriteLine();

                charList.Reverse();

                foreach (char thing in charList)
                {
                    Console.Write("{0} ", thing);
                }
                Console.WriteLine();
            }


        }

        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintTheBetweenChars(firstChar, secondChar);
        }
    }
}
