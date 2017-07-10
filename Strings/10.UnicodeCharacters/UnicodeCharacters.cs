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
            for (int i = 0; i < signs.Length; i++)
            {
                ToUnicode(signs[i]);
            }
            Console.WriteLine();
        }

        private static void ToUnicode(char input)
        {
            Console.Write("\\u{0:x4}", (uint)input); 
            
        }
    }
}
