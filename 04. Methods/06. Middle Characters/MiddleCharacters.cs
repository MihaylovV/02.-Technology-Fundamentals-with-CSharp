using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Middle_Characters
{
    class MiddleCharacters
    {
        static bool LenghtEvenOrNot(string input)
        {
            int lenght = input.Length;
            bool isEven;

            if (lenght % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }

            return isEven;
        }

        static void PrintOdd(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length / 2)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

        static void PrintEven(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == (input.Length / 2) - 1)
                {
                    Console.Write(input[i]);
                }

                if (i == (input.Length / 2))
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            string input = Console.ReadLine();

            bool isEven = LenghtEvenOrNot(input);

            if (isEven == true)
            {
                PrintEven(input);
            }
            else
            {
                PrintOdd(input);
            }
        }
    }
}
