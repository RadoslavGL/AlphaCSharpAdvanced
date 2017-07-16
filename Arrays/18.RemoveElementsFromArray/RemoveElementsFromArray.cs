using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);

            int[] addArr = new int[n];

            FillAddArray(addArr);

            AddArrayCounts(numbArr, addArr);

            Console.WriteLine(addArr.Length - addArr.Max());

            PrintArray(addArr);
        }

        private static void AddArrayCounts(int[] numbArr, int[] addArr)
        {
            for (int i = 1; i < numbArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbArr[i] >= numbArr[j] && addArr[i] < (addArr[j] + 1))
                    {
                        addArr[i] = addArr[j] + 1;
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

        public static void FillAddArray(int[] addArr)
        {
            for (int i = 0; i < addArr.Length; i++)
            {
                addArr[i] = 1;
            }

        }

        public static void PrintArray(int[] numbArr)
        {
            Console.WriteLine(string.Join("\n", numbArr));

        }

    }
}
