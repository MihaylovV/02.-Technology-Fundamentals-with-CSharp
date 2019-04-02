using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Water_Overflow
{
    class WaterOverflow
    {
        static void Main()
        {
            int tankCapacity = 255;
            int waterPoured = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if (litersToPour + waterPoured < tankCapacity)
                {
                    waterPoured += litersToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(waterPoured);
        }
    }
}
