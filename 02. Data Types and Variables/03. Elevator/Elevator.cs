using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            int numberOfTrips = (int)Math.Ceiling((double)numberOfPeople / capacityOfPeople);

            Console.WriteLine(numberOfTrips);
        }
    }
}
