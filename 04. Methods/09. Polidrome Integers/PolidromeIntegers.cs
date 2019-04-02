using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Polidrome_Integers
{
    class PolidromeIntegers
    {
        static string ReverseMyString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void CheckQuestNumbers(List<string> numbers)
        {
            List<string> reversedNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string reversedNumber = numbers[i];

                string result = ReverseMyString(reversedNumber);

                reversedNumbers.Add(result);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int firstNum = int.Parse(numbers[i]);
                int secondNum = int.Parse(reversedNumbers[i]);

                if (firstNum == secondNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static void Main()
        {
            List<string> numbersList = new List<string>();

            bool isWorking = true;
            while (isWorking == true)
            {
                string input = Console.ReadLine();

                if (input == "End" || input == "END")
                {
                    isWorking = false;
                }
                else
                {
                    string number = input;
                    numbersList.Add(number);
                }
            }

            CheckQuestNumbers(numbersList);
        }
    }
}
