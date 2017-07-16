using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            char[] signs = word.ToCharArray();

            StringBuilder sbUnicodeChars = new StringBuilder();

            ToUnicode(signs, sbUnicodeChars);

            Console.WriteLine(sbUnicodeChars.ToString().Trim());
        }

        public static void ToUnicode(char[] signs, StringBuilder sbUnicodeChars)
        {
            for (int i = 0; i < signs.Length; i++)
            {
                sbUnicodeChars.Append("\\u" + ((int)signs[i]).ToString("X4"));

            }
        }
    }
}

    

