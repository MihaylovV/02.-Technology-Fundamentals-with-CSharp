﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triple_Latin
{
    class TripleLatin
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + n; a++)
            {
                for (char b = 'a'; b < 'a' + n; b++)
                {
                    for (char c = 'a'; c < 'a' + n; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
