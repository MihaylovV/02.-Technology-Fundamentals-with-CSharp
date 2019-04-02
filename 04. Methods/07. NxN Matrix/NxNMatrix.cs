using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NxN_Matrix
{
    class NxNMatrix
    {
        static void PrintMatrix(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write("{0} ", input);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintMatrix(input);
        }
    }
}
