using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rage_Expenses
{
    class RageExpenses
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            int displayCount = 0;

            for (int i = 1; i < lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    rageExpenses += keyboardPrice;
                    displayCount++;
                    if (displayCount == 2)
                    {
                        rageExpenses += displayPrice;
                        displayCount = 0;
                    }
                }
            }

            Console.WriteLine("Rage expenses: {0:F2} lv.", rageExpenses);
        }
    }
}
}
