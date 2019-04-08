using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Legendary_Farming
{
    class LegendaryFarming
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("Shards", 0);
            keyMaterials.Add("Fragments", 0);
            keyMaterials.Add("Motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool shadowMourne = false;
            bool valanyr = false;
            bool dragonWrath = false;

            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();

                List<string> commandsList = input.Split(' ').ToList();

                List<int> quantityList = new List<int>();
                List<string> materialList = new List<string>();

                for (int i = 0; i < commandsList.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantityList.Add(int.Parse(commandsList[i]));
                    }
                    else if (i % 2 != 0)
                    {
                        materialList.Add(commandsList[i].ToLower());
                    }
                }

                for (int i = 0; i < materialList.Count; i++)
                {
                    if (materialList[i] == "shards")
                    {
                        keyMaterials["Shards"] += quantityList[i];
                        if (keyMaterials["Shards"] >= 250)
                        {
                            shadowMourne = true;
                            keyMaterials["Shards"] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else if (materialList[i] == "fragments")
                    {
                        keyMaterials["Fragments"] += quantityList[i];
                        if (keyMaterials["Fragments"] >= 250)
                        {
                            valanyr = true;
                            keyMaterials["Fragments"] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else if (materialList[i] == "motes")
                    {
                        keyMaterials["Motes"] += quantityList[i];
                        if (keyMaterials["Motes"] >= 250)
                        {
                            dragonWrath = true;
                            keyMaterials["Motes"] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(materialList[i]))
                        {
                            junk.Add(materialList[i], quantityList[i]);
                        }
                        else
                        {
                            junk[materialList[i]] += quantityList[i];
                        }
                    }
                }
            }

            // Print obtained item
            string reward = "";
            if (shadowMourne == true)
            {
                reward = "ShadowMourne";
            }
            else if (valanyr == true)
            {
                reward = "Valanyr";
            }
            else if (dragonWrath == true)
            {
                reward = "DragonWrath";
            }
            Console.WriteLine("{0} obtained!", reward);

            // Print Rest

            var leftoverKeyMaterials = from pair in keyMaterials
                                       orderby pair.Value descending
                                       select pair;

            if (keyMaterials["Shards"] == keyMaterials["Fragments"] || keyMaterials["Shards"] == keyMaterials["Motes"] || keyMaterials["Fragments"] == keyMaterials["Motes"])
            {
                leftoverKeyMaterials = from pair in leftoverKeyMaterials
                                       orderby pair.Key ascending
                                       select pair;
            }

            var leftoverJunk = from pair in junk
                               orderby pair.Key ascending
                               select pair;

            foreach (var item in leftoverKeyMaterials)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            foreach (var item in leftoverJunk)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
