using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Soft_Uni_Parking
{
    class SoftUniParking
    {
        static void Main()
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> carLotDatabase = new Dictionary<string, string>();
            for (int i = 0; i < numOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ').ToArray();
                switch (inputArray[0])
                {
                    case "register":
                        if (carLotDatabase.ContainsValue(inputArray[2]))
                        {
                            Console.WriteLine("ERROR: already registered with plate number {0}", inputArray[2]);
                        }
                        else
                        {
                            carLotDatabase.Add(inputArray[1], inputArray[2]);
                            Console.WriteLine("{0} registered {1} successfully", inputArray[1], inputArray[2]);
                        }
                        break;

                    case "unregister":
                        if (carLotDatabase.ContainsKey(inputArray[1]))
                        {
                            carLotDatabase.Remove(inputArray[1]);
                            Console.WriteLine("{1} unregistered successfully", inputArray[1]);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: user {0} not found", inputArray[1]);
                        }
                        break; ;
                }
            }

            foreach (var item in carLotDatabase)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }
        }
    }
}
