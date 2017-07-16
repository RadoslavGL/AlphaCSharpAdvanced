using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);

            QuickSorter(numbArr, 0, numbArr.Length - 1);

            PrintArray(numbArr);
        }

        public static void FillTheArray(int[] numbArr)
        {
            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = int.Parse(Console.ReadLine());
            }

        }

        public static void QuickSorter(int[] numbArr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(numbArr, left, right);

                //recurtion
                QuickSorter(numbArr, left, pivot - 1);
                QuickSorter(numbArr, pivot + 1, right);

            }
            
        }

        public static int Partition(int[] numbArr, int left, int right)
        {
            int pivot = numbArr[left];

            while (true)
            {
                while (pivot > numbArr[left])
                {
                    left++;
                }

                while (pivot < numbArr[right])
                {
                    right--;
                }

                if (numbArr[right] == pivot && numbArr[left] == pivot)
                {
                    left++;
                }

                if (left >= right)
                {
                    return right;
                }

                int swap = numbArr[left];
                numbArr[left] = numbArr[right];
                numbArr[right] = swap;
            }


        }



        public static void PrintArray(int[] numbArr)
        {
            Console.WriteLine(string.Join("\n", numbArr));

        }

    }
}
