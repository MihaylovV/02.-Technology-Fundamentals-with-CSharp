using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Triangle_Of_Numbers
{
    class TrianbleOfNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write(" {0}", i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
