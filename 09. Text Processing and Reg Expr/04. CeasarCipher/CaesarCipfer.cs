using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CeasarCipher
{
    class CaesarCipfer
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder strBuild = new StringBuilder();

            byte[] str1Values = Encoding.ASCII.GetBytes(input);

            byte[] str2Values = new byte[str1Values.Length];

            for (int i = 0; i < str2Values.Length; i++)
            {
                str2Values[i] = Convert.ToByte(Convert.ToInt32(str1Values[i]) + 3);
            }

            for (int i = 0; i < str2Values.Length; i++)
            {
                strBuild.Append(Convert.ToChar(str2Values[i]));
            }

            string encryptedText = strBuild.ToString();

            Console.WriteLine(encryptedText);
        }
    }
}
