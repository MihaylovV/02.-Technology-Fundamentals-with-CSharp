using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Password_Validator
{
    class PasswordValidator
    {
        static bool ValidLenght(string input)
        {
            bool LenghtIsValid;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                count++;
            }

            if (count < 6 || count > 10)
            {
                LenghtIsValid = false;
            }
            else
            {
                LenghtIsValid = true;
            }

            return LenghtIsValid;
        }

        static bool ValidSymbols(string input)
        {
            bool validSymbols;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isCharOrDigit = char.IsLetterOrDigit(input[i]);

                if (isCharOrDigit == false)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                validSymbols = false;
            }
            else
            {
                validSymbols = true;
            }

            return validSymbols;
        }

        static bool ValidNumOfChars(string input)
        {
            bool validNumberChars;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool validDigit = char.IsDigit(input[i]);

                if (validDigit == true)
                {
                    count++;
                }
            }

            if (count > 1)
            {
                validNumberChars = true;
            }
            else
            {
                validNumberChars = false;
            }

            return validNumberChars;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            bool validLenght = ValidLenght(input);
            bool validSymbols = ValidSymbols(input);
            bool validNumOfChars = ValidNumOfChars(input);

            if (validLenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (validSymbols == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (validNumOfChars == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (validLenght == true && validSymbols == true && validNumOfChars == true)
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}
