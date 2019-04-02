using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Spice_Must_Flow
{
    class SpiceMustFlow
    {
        static void Main()
        {
            int totalYield = 0;
            int yieldPerDay = int.Parse(Console.ReadLine());
            int daysMined = 0;
            bool isWorthIt = true;

            while (isWorthIt == true)
            {
                if (yieldPerDay < 100)
                {
                    totalYield -= 26;
                    isWorthIt = false;
                    break;
                }

                totalYield = totalYield + yieldPerDay;
                totalYield = totalYield - 26;
                yieldPerDay = yieldPerDay - 10;
                daysMined++;
            }

            Console.WriteLine(daysMined);
            Console.WriteLine(totalYield);
        }
    }
}
