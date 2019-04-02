using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pokemon
{
    class Pokemon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int originalN = n;

            int countPokes = 0;

            while (n > m)
            {
                n -= m;
                countPokes++;
                if (n == originalN / 2)
                {
                    if (n % y == 0)
                    {
                        n = n / y;
                    }
                    else if (n % y != 0)
                    {
                        n = n / y;
                    }

                }
            }

            Console.WriteLine(n);
            Console.WriteLine(countPokes);
        }
    }
}
