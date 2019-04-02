using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main()
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfStay = Console.ReadLine();

            double totalPrice = 0.00;

            if (typeOfPeople == "Students")
            {
                if (dayOfStay == "Friday")
                {
                    totalPrice = numberOfPeople * 8.45;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = numberOfPeople * 9.80;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = numberOfPeople * 10.46;
                }

                if (numberOfPeople >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
            }

            else if (typeOfPeople == "Business")
            {
                if (dayOfStay == "Friday")
                {
                    totalPrice = numberOfPeople * 10.90;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = numberOfPeople * 15.60;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = numberOfPeople * 16;
                }

                if (numberOfPeople >= 100)
                {
                    if (dayOfStay == "Friday")
                    {
                        totalPrice = totalPrice - (10 * 10.90);
                    }
                    else if (dayOfStay == "Saturday")
                    {
                        totalPrice = totalPrice - (10 * 15.60);
                    }
                    else if (dayOfStay == "Sunday")
                    {
                        totalPrice = totalPrice - (10 * 16);
                    }
                }
            }

            else if (typeOfPeople == "Regular")
            {
                if (dayOfStay == "Friday")
                {
                    totalPrice = numberOfPeople * 15;
                }
                else if (dayOfStay == "Saturday")
                {
                    totalPrice = numberOfPeople * 20;
                }
                else if (dayOfStay == "Sunday")
                {
                    totalPrice = numberOfPeople * 22.50;
                }

                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice = totalPrice * (totalPrice * 0.05);
                }
            }

            Console.WriteLine("Total price: {0:F2}", totalPrice);
        }
    }
}
