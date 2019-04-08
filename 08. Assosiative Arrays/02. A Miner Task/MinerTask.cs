using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.A_Miner_Task
{
    class MinerTask
    {
        static void Main()
        {
            Dictionary<string, ulong> resourcesDatabase = new Dictionary<string, ulong>();

            bool isRunning = true;
            while (isRunning == true)
            {
                string resourceInput = Console.ReadLine();
                if (resourceInput == "stop")
                {
                    isRunning = false;
                }
                else
                {
                    ulong quantityInput = ulong.Parse(Console.ReadLine());

                    if (!resourcesDatabase.ContainsKey(resourceInput))
                    {
                        resourcesDatabase.Add(resourceInput, 0);
                        resourcesDatabase[resourceInput] += quantityInput;
                    }
                    else if (resourcesDatabase.ContainsKey(resourceInput))
                    {
                        resourcesDatabase[resourceInput] += quantityInput;
                    }
                }
            }

            foreach (var resource in resourcesDatabase)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
            Console.WriteLine();
        }
    }
}
