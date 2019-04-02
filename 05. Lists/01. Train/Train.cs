using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Train
{
    class Train
    {
        static List<int> GetTrainWagonInfo(string initialInput)
        {
            char[] separators = new char[] { ' ' };
            string[] wagonInfo = initialInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<int> trainWagonInfo = new List<int>();

            for (int i = 0; i < wagonInfo.Length; i++)
            {
                trainWagonInfo.Add(int.Parse(wagonInfo[i]));
            }

            return trainWagonInfo;
        }

        static List<int> AddWagonAtEnd(List<int> trainWagonInfo, int passangerCount)
        {
            trainWagonInfo.Add(passangerCount);
            return trainWagonInfo;
        }

        static List<int> AddPassangers(List<int> trainWagonInfo, int maxCapacity, int passangerCount)
        {
            for (int i = 0; i < trainWagonInfo.Count; i++)
            {
                if (trainWagonInfo[i] + passangerCount <= maxCapacity)
                {
                    trainWagonInfo[i] += passangerCount;
                    break;
                }
            }

            return trainWagonInfo;
        }

        static void Main()
        {
            string initialInput = Console.ReadLine();

            List<int> trainWagonInfo = GetTrainWagonInfo(initialInput);

            int maxCapacityWagon = int.Parse(Console.ReadLine());

            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();

                char[] separators = new char[] { ' ' };
                string[] inputAnalysis = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (inputAnalysis[0] == "Add")
                {
                    int passangerCount = int.Parse(inputAnalysis[1]);
                    trainWagonInfo = AddWagonAtEnd(trainWagonInfo, passangerCount);
                }
                else if (inputAnalysis[0] == "end")
                {
                    isRunning = false;
                }
                else
                {
                    int passangersToAdd = int.Parse(inputAnalysis[0]);
                    trainWagonInfo = AddPassangers(trainWagonInfo, maxCapacityWagon, passangersToAdd);
                }
            }

            for (int i = 0; i < trainWagonInfo.Count; i++)
            {
                Console.Write("{0} ", trainWagonInfo[i]);
            }
            Console.WriteLine();
        }
    }
}
