using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_Operations
{
    class ListOperations
    {
        static List<long> GetUserNumbers()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ' };
            string[] stringArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<long> userNumbers = new List<long>();

            for (long i = 0; i < stringArray.Length; i++)
            {
                userNumbers.Add(long.Parse(stringArray[i]));
            }

            return userNumbers;
        }

        static List<long> AddNumberMethod(List<long> userNumbers, long numberToAddAtEnd)
        {
            userNumbers.Add(numberToAddAtEnd);

            return userNumbers;
        }

        static List<long> InsertNumberAtIndexMethod(List<long> userNumbers, long numberToInsert, int atIndex)
        {
            if (atIndex >= userNumbers.Count || atIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                userNumbers.Insert(atIndex, numberToInsert);
            }

            return userNumbers;
        }

        static List<long> RemoveElementAtIndex(List<long> userNumbers, int removeAtIndex)
        {
            if (removeAtIndex >= userNumbers.Count || removeAtIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                userNumbers.RemoveAt(removeAtIndex);
            }

            return userNumbers;
        }

        static List<long> ShiftLeftMethod(List<long> userNumbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                long temp = userNumbers[0];
                userNumbers.RemoveAt(0);
                userNumbers.Add(temp);
            }

            return userNumbers;
        }

        static List<long> ShiftRightMethod(List<long> userNumbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                long temp = userNumbers[userNumbers.Count - 1];
                userNumbers.RemoveAt(userNumbers.Count - 1);
                userNumbers.Insert(0, temp);
            }

            return userNumbers;
        }

        static void Main()
        {
            List<long> userNumbers = GetUserNumbers();

            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();
                char[] separators = new char[] { ' ' };
                string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandsArray[0] == "End")
                {
                    isRunning = false;
                    break;
                }

                // Add {number} - add number at the end.
                else if (commandsArray[0] == "Add")
                {
                    userNumbers = AddNumberMethod(userNumbers, int.Parse(commandsArray[1]));
                }

                // Insert {number} {index} - insert number at given index.
                else if (commandsArray[0] == "Insert")
                {
                    userNumbers = InsertNumberAtIndexMethod(userNumbers, int.Parse(commandsArray[1]), int.Parse(commandsArray[2]));
                }

                // Remove {index} - remove at index.
                else if (commandsArray[0] == "Remove")
                {
                    userNumbers = RemoveElementAtIndex(userNumbers, int.Parse(commandsArray[1]));
                }

                // Shift left {count} - first number becomes last 'count' times.
                else if (commandsArray[0] == "Shift" && commandsArray[1] == "left")
                {
                    userNumbers = ShiftLeftMethod(userNumbers, int.Parse(commandsArray[2]));
                }

                // Shift right {count} - last number becomes first 'count' times.
                else if (commandsArray[0] == "Shift" && commandsArray[1] == "right")
                {
                    userNumbers = ShiftRightMethod(userNumbers, int.Parse(commandsArray[2]));
                }
            }

            for (int i = 0; i < userNumbers.Count; i++)
            {
                Console.Write("{0} ", userNumbers[i]);
            }
            Console.WriteLine();
        }
    }
}
