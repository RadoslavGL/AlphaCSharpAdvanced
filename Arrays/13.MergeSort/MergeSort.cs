using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);
            numbArr = MergeSorter(numbArr);

            PrintArray(numbArr);

        }
                
        public static void FillTheArray(int[] numbArr)
        {
            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = int.Parse(Console.ReadLine());
            }

        }

        public static int[] MergeSorter(int[] numbArr)
        {
            //base case; 1 element ==> sorted!
            if (numbArr.Length <= 1)
            {
                return numbArr;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < numbArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    left.Add(numbArr[i]);
                }
                else
                {
                    right.Add(numbArr[i]);
                }

            }

            //recursion
            left = MergeSorter(left.ToArray()).ToList();
            right = MergeSorter(right.ToArray()).ToList();

            return Merger(left, right);
        }

        public static int[] Merger(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {

                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }

            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result.ToArray();
        }

        public static void PrintArray(int[] numbArr)
        {
            Console.WriteLine(string.Join("\n", numbArr));

        }
    }



}
