using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Orders
{
    class Order
    {
        static void Main()
        {
            Dictionary<string, List<double>> productDatabase = new Dictionary<string, List<double>>();

            bool isRunning = true;
            while (isRunning == true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "buy")
                {
                    isRunning = false;
                    break;
                }
                char[] separators = new char[] { ' ' };
                string[] commands = userInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string name = commands[0];
                double price = double.Parse(commands[1]);
                double quantity = double.Parse(commands[2]);

                List<double> priceAndQuantity = new List<double>();
                priceAndQuantity.Add(price);
                priceAndQuantity.Add(quantity);

                if (!productDatabase.ContainsKey(name))
                {
                    productDatabase.Add(name, priceAndQuantity);
                }
                else
                {
                    productDatabase[name][0] = price;
                    productDatabase[name][1] += quantity;
                }
            }
            //
            foreach (var item in productDatabase)
            {
                double sum = item.Value[0] * item.Value[1];
                Console.WriteLine("{0:F2} -> {1:F2}", item.Key, sum);
            }
        }
    }
}
