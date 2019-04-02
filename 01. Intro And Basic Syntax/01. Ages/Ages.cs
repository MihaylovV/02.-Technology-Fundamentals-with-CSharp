using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Ages
{
    class Ages
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (input >= 3 && input <= 13)
            {
                Console.WriteLine("child");
            }
            else if (input >= 14 && input <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (input >= 20 && input <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (input >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
