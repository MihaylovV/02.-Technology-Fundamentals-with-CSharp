using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Advert_Message
{
    class AdvertisementMessage
    {
        static string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public static void PrintMessage(int phraseNum, int eventNum, int authorNum, int cityNum)
        {
            Console.WriteLine("{0} {1} {2} - {3}", Phrases[phraseNum], Events[eventNum], Authors[authorNum], Cities[cityNum]);
        }
    }

    class AdMessage
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Random rand = new Random();

            List<AdvertisementMessage> adsList = new List<AdvertisementMessage>();

            for (int i = 0; i < input; i++)
            {
                AdvertisementMessage.PrintMessage(rand.Next(6), rand.Next(7), rand.Next(8), rand.Next(5));
            }
        }
    }
}
