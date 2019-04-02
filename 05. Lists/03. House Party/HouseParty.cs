using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.House_Party
{
    class HouseParty
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> peopleGoing = new List<string>();

            char[] separators = new char[] { ' ' };

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandsArray[2] == "going!")
                {
                    int count = 0;

                    for (int j = 0; j < peopleGoing.Count; j++)
                    {
                        if (commandsArray[0] == peopleGoing[j])
                        {
                            count++;
                            Console.WriteLine("{0} is already in the list!", commandsArray[0]);
                        }
                    }

                    if (count == 0)
                    {
                        peopleGoing.Add(commandsArray[0]);
                    }
                }

                else if (commandsArray[2] == "not")
                {
                    int count = 0;

                    for (int j = 0; j < peopleGoing.Count; j++)
                    {
                        if (commandsArray[0] == peopleGoing[j])
                        {
                            peopleGoing.RemoveAt(j);
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("{0} is not in the list!", commandsArray[0]);
                    }
                }
            }

            foreach (string name in peopleGoing)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
