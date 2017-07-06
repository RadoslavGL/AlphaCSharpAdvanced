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
            string text = "";
            string forbiddenWords = "";

            using (StreamReader inputReader = new StreamReader("input.txt"))
            {
                text = inputReader.ReadLine();
                forbiddenWords = inputReader.ReadLine();
            }

            StringBuilder textSB = new StringBuilder();
            string[] textWords = text.Split(' ');
            string[] forbWordsStr = forbiddenWords.Split(' ');


        }
    }
}
