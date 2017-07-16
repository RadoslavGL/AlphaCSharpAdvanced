using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://gitlab.com/TelerikAcademy/alpha/tree/master/C%23-Advanced/Strings-and-Text-Processing/tasks/09.%20Forbidden%20words

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string sentences = Console.ReadLine();
            string forbiddenWords = Console.ReadLine();

            string[] forbiddenWordsArr = forbiddenWords.Split(new char[] { ' ', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder sbSentences = new StringBuilder(sentences);

            for (int i = 0; i < forbiddenWordsArr.Length; i++)
            {
                string forbiddenArrMember = forbiddenWordsArr[i];
                string replacement = new String('*', forbiddenArrMember.Length);
                sbSentences.Replace(forbiddenArrMember, replacement);
            }

            Console.WriteLine(sbSentences.ToString());
        }
    }
}
