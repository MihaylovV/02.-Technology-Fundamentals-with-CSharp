using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
    class VendingMachine
    {
        static void Main()
        {
            double sumTotalCoins = 0;
            double sumTotalPrice = 0;

            bool insertingCoins = true;
            while (insertingCoins == true)
            {
                string input = Console.ReadLine();

                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    double coin = double.Parse(input);
                    sumTotalCoins += coin;
                }
                else if (input == "Start")
                {
                    insertingCoins = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", input);
                }
            }

            bool buyingShit = true;
            while (buyingShit == true)
            {
                string input = Console.ReadLine();
                if (input == "Nuts")
                {
                    if (sumTotalPrice + 2 <= sumTotalCoins)
                    {
                        sumTotalPrice += 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (sumTotalPrice + 0.7 <= sumTotalCoins)
                    {
                        sumTotalPrice += 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (sumTotalPrice + 1.5 <= sumTotalCoins)
                    {
                        sumTotalPrice += 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (sumTotalPrice + 0.8 <= sumTotalCoins)
                    {
                        sumTotalPrice += 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (sumTotalPrice + 1.0 <= sumTotalCoins)
                    {
                        sumTotalPrice += 1.0;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "End")
                {
                    buyingShit = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

            }

            double change = sumTotalCoins - sumTotalPrice;
            Console.WriteLine("Change: {0:F2}", change);
        }
    }
}
