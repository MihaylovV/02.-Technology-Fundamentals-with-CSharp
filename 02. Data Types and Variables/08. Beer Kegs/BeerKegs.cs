using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Beer_Kegs
{
    class BeerKegs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int bestVolume = 0;

            string bestKeg = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                int kegVolume = (int)Math.PI * ((int)radius ^ 2) * (int)height;

                if (kegVolume > bestVolume)
                {
                    bestVolume = kegVolume;
                    bestKeg = model;
                }
            }

            Console.WriteLine(bestKeg);
        }
    }
}
