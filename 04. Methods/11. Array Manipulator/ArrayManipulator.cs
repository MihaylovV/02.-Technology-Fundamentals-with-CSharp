using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Array_Manipulator
{
    class ArrayManipulator
    {
        static int[] GetIntegerArray(string input)
        {
            char[] separators = new char[] { ' ' };
            string[] stringArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] numbersArray = new int[stringArray.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(stringArray[i]);
            }

            return numbersArray;
        }

        static string[] GetCommands(string userInput)
        {
            char[] separators = new char[] { ' ' };
            string[] commandsArray = userInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return commandsArray;
        }

        static int[] ExchangeMethod(string exchangeCommand, string exchangeCount, int[] numbersArray)
        {
            int exchangeIndex = int.Parse(exchangeCount);
            if (exchangeIndex > numbersArray.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] tempArray = new int[numbersArray.Length];
                int count = 0;

                for (int i = exchangeIndex + 1; i < numbersArray.Length; i++)
                {
                    tempArray[count] = numbersArray[i];
                    count++;
                }
                for (int i = 0; i < exchangeIndex + 1; i++)
                {
                    tempArray[count] = numbersArray[i];
                    count++;
                }
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    numbersArray[i] = tempArray[i];
                }
            }

            return numbersArray;
        }

        static void MaxMinEvenOdd(string minOrMax, string oddOrEven, int[] numbersArray)
        {
            string command = minOrMax;
            string type = oddOrEven;
            int bestNumberIndex = 0;
            int bestNumberMax = 0;
            int bestNumberMin = int.MaxValue;

            if (command == "max")
            {
                if (type == "even")
                {
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (numbersArray[i] % 2 == 0)
                        {
                            if (numbersArray[i] > bestNumberMax)
                            {
                                bestNumberMax = numbersArray[i];
                                bestNumberIndex = i;
                            }
                        }
                    }
                }
                else if (type == "odd")
                {
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (numbersArray[i] % 2 != 0)
                        {
                            if (numbersArray[i] > bestNumberMax)
                            {
                                bestNumberMax = numbersArray[i];
                                bestNumberIndex = i;
                            }
                        }
                    }
                }
            }
            else if (command == "min")
            {
                if (type == "even")
                {
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (numbersArray[i] % 2 == 0)
                        {
                            if (numbersArray[i] < bestNumberMin)
                            {
                                bestNumberMin = numbersArray[i];
                                bestNumberIndex = i;
                            }
                        }
                    }
                }
                else if (type == "odd")
                {
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (numbersArray[i] % 2 != 0)
                        {
                            if (numbersArray[i] < bestNumberMin)
                            {
                                bestNumberMin = numbersArray[i];
                                bestNumberIndex = i;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(bestNumberIndex);

        }

        static void FirstLastCount(string firstLast, string count, string oddEven, int[] numbersArray)
        {
            string command = firstLast;
            string type = oddEven;
            int countNumber = int.Parse(count);

            List<int> countEven = new List<int>();
            List<int> countOdd = new List<int>();
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0 && numbersArray[i] != 1)
                {
                    countEven.Add(numbersArray[i]);
                }
                else if (numbersArray[i] == 1)
                {
                    countOdd.Add(numbersArray[i]);
                }
                else
                {
                    countOdd.Add(numbersArray[i]);
                }
            }

            if (command == "first")
            {
                if (type == "even")
                {
                    if (countNumber > countEven.Count)
                    {
                        countNumber = countEven.Count;
                    }

                    for (int i = 0; i < countNumber; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("[{0}, ", countEven[i]);
                        }
                        if (i != 0 && i < countEven.Count - 1)
                        {
                            Console.Write("{0}, ", countEven[i]);
                        }
                        if (i == countEven.Count - 1)
                        {
                            Console.Write("{0}]", countEven[i]);
                        }
                    }
                    Console.WriteLine();
                }

                else if (type == "odd")
                {
                    if (countNumber > countOdd.Count)
                    {
                        countNumber = countOdd.Count;
                    }

                    for (int i = 0; i < countNumber; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("[{0}, ", countOdd[i]);
                        }
                        if (i != 0 && i < countOdd.Count - 1)
                        {
                            Console.Write("{0}, ", countOdd[i]);
                        }
                        if (i == countOdd.Count - 1)
                        {
                            Console.Write("{0}]", countOdd[i]);
                        }
                    }
                    Console.WriteLine();
                }
            }

            else if (command == "last")
            {
                if (type == "even")
                {
                    if (countNumber > countEven.Count)
                    {
                        countNumber = countEven.Count;
                    }

                    int startIndex = (countEven.Count) - countNumber;

                    for (int i = startIndex; i < countEven.Count; i++)
                    {
                        if (i == startIndex)
                        {
                            Console.Write("[{0}, ", countEven[i]);
                        }
                        if (i != startIndex && i != countEven.Count - 1)
                        {
                            Console.Write("{0}, ", countEven[i]);
                        }
                        if (i == countEven.Count - 1)
                        {
                            Console.Write("{0}]", countEven[i]);
                        }
                    }
                    Console.WriteLine();
                }

                else if (type == "odd")
                {
                    if (countNumber > countOdd.Count)
                    {
                        countNumber = countOdd.Count;
                    }

                    int startIndex = (countOdd.Count) - countNumber;

                    for (int i = startIndex; i < countEven.Count; i++)
                    {
                        if (i == startIndex)
                        {
                            Console.Write("[{0}, ", countOdd[i]);
                        }
                        if (i != startIndex && i != countOdd.Count - 1)
                        {
                            Console.Write("{0}, ", countOdd[i]);
                        }
                        if (i == countOdd.Count - 1)
                        {
                            Console.Write("{0}]", countOdd[i]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();

            int[] numbersArray = GetIntegerArray(input);

            bool isWorking = true;
            while (isWorking == true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    isWorking = false;
                }
                else if (userInput == "print")
                {
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("[{0}, ", numbersArray[i]);
                        }
                        if (i != 0 && i < numbersArray.Length - 1)
                        {
                            Console.Write("{0}, ", numbersArray[i]);
                        }
                        if (i == numbersArray.Length - 1)
                        {
                            Console.Write("{0}]", numbersArray[i]);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    string[] commandsArray = GetCommands(userInput);

                    if (commandsArray[0] == "exchange")
                    {
                        numbersArray = ExchangeMethod(commandsArray[0], commandsArray[1], numbersArray);
                    }
                    else if (commandsArray[0] == "max" || commandsArray[0] == "min")
                    {
                        MaxMinEvenOdd(commandsArray[0], commandsArray[1], numbersArray);
                    }
                    else if (commandsArray[0] == "first" || commandsArray[0] == "last")
                    {
                        FirstLastCount(commandsArray[0], commandsArray[1], commandsArray[2], numbersArray);
                    }
                }
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[{0}, ", numbersArray[i]);
                }
                if (i != 0 && i < numbersArray.Length - 1)
                {
                    Console.Write("{0}, ", numbersArray[i]);
                }
                if (i == numbersArray.Length - 1)
                {
                    Console.Write("{0}]", numbersArray[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
