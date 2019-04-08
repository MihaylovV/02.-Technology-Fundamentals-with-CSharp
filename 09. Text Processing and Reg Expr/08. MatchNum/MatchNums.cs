using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MatchNum
{
    class MatchNums
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();

            List<string> resultList = new List<string>();

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            for (int i = 0; i < inputArray.Length; i++)
            {
                Match match = Regex.Match(inputArray[i], pattern);
                if (match.Success)
                {
                    resultList.Add(match.Value);
                }
            }

            foreach (var item in resultList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
