//You are given an array of strings. Write a method that sorts the array by the length
// of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortByStringLength
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] { "aaaa", "bbbb", "asasss", "edresrer", "tsrepfsefs", "sefs" };

            SortByLength(strArr);

            Console.WriteLine(string.Join("\n", strArr));
        }

        public static void SortByLength(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                for (int j = i+1; j < strArr.Length; j++)
                {
                    if (strArr[i].Length > strArr[j].Length)
                    {
                        string swap = strArr[i];
                        strArr[i] = strArr[j];
                        strArr[j] = swap;
                    }
                }
            }
        }
    }
}
