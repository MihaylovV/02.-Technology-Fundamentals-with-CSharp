using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Valid_User
{
    class ValidUser
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> userNamesList = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<int, char> Alphabet = AlphabetChars();
            List<string> validUserNamesList = new List<string>();

            foreach (var username in userNamesList)
            {
                bool legitUserName = true;

                for (int i = 0; i < username.Length; i++)
                {
                    if (!Alphabet.ContainsValue(username[i]))
                    {
                        legitUserName = false;
                        break;
                    }
                    else
                    {
                        legitUserName = true;
                    }
                }

                if (legitUserName == true && username.Length >= 3 && username.Length <= 16)
                {
                    validUserNamesList.Add(username);
                }
            }

            foreach (var item in validUserNamesList)
            {
                Console.WriteLine(item);
            }

        }

        static Dictionary<int, char> AlphabetChars()
        {
            int index = 12;
            Dictionary<int, char> Alphabet = new Dictionary<int, char>();
            Alphabet.Add(0, '-');
            Alphabet.Add(1, '_');
            Alphabet.Add(2, '0');
            Alphabet.Add(3, '1');
            Alphabet.Add(4, '2');
            Alphabet.Add(5, '3');
            Alphabet.Add(6, '4');
            Alphabet.Add(7, '5');
            Alphabet.Add(8, '6');
            Alphabet.Add(9, '7');
            Alphabet.Add(10, '8');
            Alphabet.Add(11, '9');


            for (char i = 'A'; i <= 'Z'; i++)
            {
                Alphabet.Add(index, i);
                index++;
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                Alphabet.Add(index, i);
                index++;
            }

            return Alphabet;
        }
    }
}
