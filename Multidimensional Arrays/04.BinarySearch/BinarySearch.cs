//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array
// which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArr = new int[n];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int k = int.Parse(Console.ReadLine());

            Array.Sort(numArr);






        }
    }
}
