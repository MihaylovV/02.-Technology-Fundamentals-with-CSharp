using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Chars_in_String
{
    class CharacterCount
    {
        public static Dictionary<char, ulong> Count(string stringToCount)
        {
            Dictionary<char, ulong> characterCount = new Dictionary<char, ulong>();

            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
        }
    }

    class CountCharsString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var count = CharacterCount.Count(input);

            foreach (var character in count)
            {
                if (character.Key != ' ')
                {
                    Console.WriteLine("{0} -> {1}", character.Key, character.Value);
                }

            }

            Console.WriteLine();
        }
    }
}
