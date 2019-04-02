using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Smallest_Of_Three_Numbers
{
    class SmallestOfThreeNums
    {
        static int SmallestOfThree(int first, int second, int third)
        {
            int smallest = 0;

            if (first <= second && first <= third)
            {
                smallest = first;
            }
            else if (second <= first && second <= third)
            {
                smallest = second;
            }
            else if (third <= first && third <= second)
            {
                smallest = third;
            }

            return smallest;
        }

        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = SmallestOfThree(first, second, third);

            Console.WriteLine(result);
        }
    }
}
