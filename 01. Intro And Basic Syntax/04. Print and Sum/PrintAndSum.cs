using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_and_Sum
{
    class PrintAndSum
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
