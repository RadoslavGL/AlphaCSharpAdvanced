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

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Array.Sort(arr);

            int k = int.Parse(Console.ReadLine());

            int largestNumber = Array.BinarySearch(arr, k);

            if (largestNumber >= 0)
            {
                Console.WriteLine(arr[largestNumber]);
            }
            else
            {
                while (largestNumber < 0)
                {
                    k--;
                    largestNumber = Array.BinarySearch(arr, k);
                }
                Console.WriteLine(arr[largestNumber]);
            }

        }
    }
}
