using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReplaceChars
{
    class ReplaceRepeating
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(input[i]);
                }
                else
                {
                    if (input[i] != input[i - 1])
                    {
                        result.Append(input[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
