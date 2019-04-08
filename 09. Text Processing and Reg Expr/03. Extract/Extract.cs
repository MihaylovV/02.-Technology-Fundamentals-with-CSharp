using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extract
{
    class Extract
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] inputArray = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] fileAndExtension = inputArray[inputArray.Length - 1].Split('.');

            Console.WriteLine("File name: {0}", fileAndExtension[0]);
            Console.WriteLine("File extension: {0}", fileAndExtension[1]);
        }
    }
}
