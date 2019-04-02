using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class ChangeList
    {
        static List<int> ParseUserInput(string input)
        {
            List<int> listOfNumbers = new List<int>();
            char[] separators = new char[] { ' ' };
            string[] numbersInStringArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbersInStringArray.Length; i++)
            {
                listOfNumbers.Add(int.Parse(numbersInStringArray[i]));
            }

            return listOfNumbers;
        }

        static List<int> DeleteElement(List<int> numbersList, int elementToDelete)
        {
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] == elementToDelete)
                {
                    numbersList.RemoveAt(i);
                }
            }

            return numbersList;
        }

        static List<int> InsertElement(List<int> numbersList, int elementToInsert, int insertPosition)
        {
            numbersList.Insert(insertPosition, elementToInsert);

            return numbersList;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            List<int> listOfNumbers = ParseUserInput(input);

            bool isWorking = true;

            while (isWorking == true)
            {
                string inputCommand = Console.ReadLine();
                char[] separators = new char[] { ' ' };
                string[] commandsArray = inputCommand.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandsArray[0] == "end")
                {
                    isWorking = false;
                }
                else if (commandsArray[0] == "Delete")
                {
                    int elementToDelete = int.Parse(commandsArray[1]);
                    listOfNumbers = DeleteElement(listOfNumbers, elementToDelete);
                }
                else if (commandsArray[0] == "Insert")
                {
                    int elementToInsert = int.Parse(commandsArray[1]);
                    int insertPosition = int.Parse(commandsArray[2]);
                    listOfNumbers = InsertElement(listOfNumbers, elementToInsert, insertPosition);
                }
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.Write("{0} ", listOfNumbers[i]);
            }

            Console.WriteLine();
        }
    }
}
