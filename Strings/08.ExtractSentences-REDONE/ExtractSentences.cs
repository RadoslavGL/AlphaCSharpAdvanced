using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//split with '.' means that when splitting by '.' we can get the separated sentances
//when this is done, we need to find the non-letter chars and use the to split the words
// - clean the sb before/after each itteration;
// - use "char.IsLetter" (bool)
//with the words split we can go and start looking for the word that is in the input
//all sentances (the loop is done a sentance per itteration) are added to a SB
//and printed at the end

namespace _08.ExtractSentences_REDONE
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            string[] sentences = text.Split('.').ToArray();

            StringBuilder nonLetters = new StringBuilder();
            StringBuilder resultSentances = new StringBuilder();

            FindWordInSentences(word, sentences, nonLetters, resultSentances);

            Console.WriteLine(resultSentances.ToString().Trim());
        }

        private static void FindWordInSentences(string word, string[] sentences, StringBuilder nonLetters, StringBuilder resultSentances)
        {
            foreach (var sentence in sentences)
            {
                nonLetters.Clear();

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) == false)
                    {
                        nonLetters.Append(sentence[i]);
                    }
                }

                char[] splitChars = nonLetters.ToString().ToCharArray();

                string[] sentenceWords = sentence.Split(splitChars, StringSplitOptions.
                    RemoveEmptyEntries).ToArray();

                if (Array.IndexOf(sentenceWords, word) > -1)
                {
                    resultSentances.Append(sentence.Trim());
                    resultSentances.Append(". ");
                }
            }
        }
    }
}
