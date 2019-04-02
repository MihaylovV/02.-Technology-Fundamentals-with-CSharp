using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Snow_Balls
{
    class SnowBalls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            int bestSnowBallSnow = 0;
            int bestSnowBallTime = 0;
            int bestSnowBallQuality = 0;

            int bestSnowBallValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                double snowBallValue = (double)(snowBallSnow / snowBallTime) * snowBallQuality;

                if (snowBallValue > bestSnowBallValue)
                {
                    bestSnowBallSnow = snowBallSnow;
                    bestSnowBallTime = snowBallTime;
                    bestSnowBallQuality = snowBallQuality;
                }
            }

            Console.WriteLine("{0} : {1} = {2} ({3})", bestSnowBallSnow, bestSnowBallTime, bestSnowBallValue, bestSnowBallQuality);
        }
    }
}
