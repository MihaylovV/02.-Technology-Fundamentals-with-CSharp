﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNum = arr[0];
            int range = arr[1];

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                if (nums[index] == bombNum)
                {
                    for (int i = 0; i <= range; i++)
                    {
                        if (index <= nums.Count - 1)
                        {
                            nums.RemoveAt(index);

                        }
                    }

                    for (int i = 1; i <= range; i++)
                    {
                        if (index - 1 >= 0)
                        {
                            nums.RemoveAt(index - 1);
                            index--;
                        }
                    }

                }
            }
            nums.RemoveAll(n => n == bombNum);
            int sum = nums.Sum();
            Console.WriteLine(sum);
        }
    }
}
}
