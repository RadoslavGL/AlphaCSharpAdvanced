using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] inputOne = Console.ReadLine().ToCharArray();
            char[] inputTwo = Console.ReadLine().ToCharArray();

            int minLen = Math.Min(inputOne.Length, inputTwo.Length);

            bool isEqual = true;
            int counter = 0;

            while (isEqual && counter < minLen)
            {
                if (inputOne[counter] == inputTwo[counter])
                {
                    counter++;
                }
                else if (inputOne[counter] > inputTwo[counter])
                {
                    isEqual = false;
                    Console.WriteLine(">");
                }
                else
                {
                    isEqual = false;
                    Console.WriteLine("<");
                }
            }

            if (isEqual)
            {
                if (inputOne.Length > inputTwo.Length)
                {
                    Console.WriteLine(">");

                }
                else if (inputOne.Length < inputTwo.Length)
                {
                    Console.WriteLine("<");

                }
                else
                {
                    Console.WriteLine("=");
                }
            }

        }
    }
}
