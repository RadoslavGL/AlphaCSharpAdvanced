using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(SearchBinary(numbArr, x));

        }

        public static int SearchBinary(int[] numbArr, int x)
        {
            int indexX = -1;
            int left = 0;
            int right = numbArr.Length - 1;
            int middle = (left + right) / 2;

            while (left <= right)
            {
                if (numbArr[middle] == x)
                {
                    indexX = middle;
                    left = right + 1;
                }
                else if (x > numbArr[middle])
                {
                    left = middle + 1;
                    middle = (left + right) / 2;
                }
                else
                {
                    right = middle - 1;
                    middle = (left + right) / 2;
                }
            }


            return indexX;
        }

        public static void FillTheArray(int[] numbArr)
        {
            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
