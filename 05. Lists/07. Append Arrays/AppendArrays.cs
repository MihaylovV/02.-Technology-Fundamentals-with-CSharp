using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Append_Arrays
{
    class AppendArrays
    {
        static List<int> AppendArraysTask(string input)
        {
            List<string> tempList = new List<string>();
            List<int> resultList = new List<int>();

            // Get all numbers before last '|'
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != ' ')
                {
                    if (input[i] != '|')
                    {
                        tempList.Add(input[i].ToString());
                    }
                    else if (input[i] == '|')
                    {
                        tempList.Reverse();
                        for (int j = 0; j < tempList.Count; j++)
                        {
                            resultList.Add(int.Parse(tempList[j]));
                        }
                        tempList.Clear();
                    }
                }
            }

            // Get last part of array lenght
            int countLastArray = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '|')
                {
                    countLastArray++;
                }
                if (input[i] == '|')
                {
                    break;
                }
            }

            // Get last part of array
            for (int i = 0; i < countLastArray; i++)
            {
                if (input[i] != ' ')
                {
                    resultList.Add(int.Parse(input[i].ToString()));
                }
            }

            return resultList;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            List<int> results = AppendArraysTask(input);

            foreach (int number in results)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
