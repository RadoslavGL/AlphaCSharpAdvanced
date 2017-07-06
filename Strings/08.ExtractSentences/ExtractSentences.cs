using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {

            string word = "";
            string text = "";

            using (StreamReader fileReader = new StreamReader("text.txt"))
            {
                word = fileReader.ReadLine();
                text = fileReader.ReadLine();
            }

            //split with '.' means that when splitting by '.' we can get the separated sentances
            //when this is done, we need to find the non-letter chars and use the to split the words
            //with the words split we can go and start looking for the word that is in the input
            //all sentances (the loop is done a sentance per itteration) are added to a SB
            //and printed at the end
            string[] sentances = text.Split('.');

            StringBuilder nonLetters = new StringBuilder();
            StringBuilder result = new StringBuilder();

            foreach (var sentance in sentances)
            {
                nonLetters.Clear();

                for (int i = 0; i < sentance.Length; i++)
                {
                    if (char.IsLetter(sentance[i]) == false)
                    {
                        nonLetters.Append(sentance[i]);
                    }
                }
                char[] splitChars = nonLetters.ToString().ToCharArray();
                string[] words = sentance.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                if (Array.IndexOf(words, word) > -1)
                {
                    result.Append(sentance.Trim());
                    result.Append(". ");
                }

            }

            using (StreamWriter fileWriter = new StreamWriter("output.txt"))
            {
                fileWriter.WriteLine(result.ToString().Trim());
            }
        }
    }
}
