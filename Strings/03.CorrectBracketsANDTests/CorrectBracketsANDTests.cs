using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBracketsANDTests
{
    class CorrectBracketsANDTests
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //int openingBrackets = input.Count(x => x == '(');
            //int closingBrackets = input.Count(x => x == ')');

            //if (openingBrackets == closingBrackets)
            //{
            //    Console.WriteLine("Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect");
            //}

            int openingBrackets = 0;
            int closingBrackets = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBrackets++;
                }

                if (input[i] == ')')
                {
                    closingBrackets++;
                }
            }

            if (openingBrackets == closingBrackets)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
