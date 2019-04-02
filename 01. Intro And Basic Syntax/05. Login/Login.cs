using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    class Login
    {
        static void Main()
        {
            // Get Username
            string userName = Console.ReadLine();

            string reversedUserName = "";
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                reversedUserName += userName[i];
            }


            // Get Password
            bool isRunning = true;
            int attemptNumber = 0;
            while (isRunning = true)
            {
                attemptNumber++;
                if (attemptNumber == 4)
                {
                    Console.WriteLine("User {0} blocked!", userName);
                    isRunning = false;
                    break;
                }

                string password = Console.ReadLine();
                if (password == reversedUserName)
                {
                    Console.WriteLine("User {0} logged in.", userName);
                    isRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
