using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Division
{
    class Division
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (input % 10 != 0 && input % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (input % 7 != 0 && input % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (input % 6 != 0 && input % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (input % 3 != 0 && input % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
