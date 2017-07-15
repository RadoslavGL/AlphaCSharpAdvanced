using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);
            SelSort(numbArr);
            PrintArray(numbArr);
        }

        public static void PrintArray(int[] numbArr)
        {
            Console.WriteLine(string.Join("\n", numbArr));

        }

        public static void SelSort(int[] numbArr)
        {
            for (int i = 0; i < numbArr.Length - 1; i++)
            {
                for (int j = i + 1; j < numbArr.Length; j++)
                {
                    int swap = 0;
                    if (numbArr[i] > numbArr[j])
                    {
                        swap = numbArr[i];
                        numbArr[i] = numbArr[j];
                        numbArr[j] = swap;
                    }
                }
            }
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
