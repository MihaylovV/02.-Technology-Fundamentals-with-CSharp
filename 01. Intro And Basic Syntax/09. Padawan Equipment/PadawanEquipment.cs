using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Padawan_Equipment
{
    class PadawanEquipment
    {
        static void Main()
        {
            double ivanChosMoney = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            // Lightsaber money
            double sumTotalLightsaberCost = priceLightsaber * (numberOfStudents + Math.Ceiling(numberOfStudents * 0.10));
            // Robe money
            double sumTotalRobeCost = priceRobe * numberOfStudents;
            // Belt money
            double freeBelts = numberOfStudents / 6;
            double sumTotalBeltCost = priceBelt * (numberOfStudents - freeBelts);
            // Total Cost
            double totalCostAcademy = sumTotalLightsaberCost + sumTotalRobeCost + sumTotalBeltCost;

            if (totalCostAcademy <= ivanChosMoney)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", totalCostAcademy);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.", totalCostAcademy - ivanChosMoney);
            }
        }
    }
}
