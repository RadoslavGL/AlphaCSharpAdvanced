using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbArr = new int[n];

            FillTheArray(numbArr);
            Console.WriteLine(FindBestSum(numbArr, k));

        }

        public static int FindBestSum(int[] numbArr, int k)
        {
            int bestSum = 0;

            Array.Sort(numbArr);

            for (int j = numbArr.Length - k; j < numbArr.Length; j++)
            {
                bestSum += numbArr[j];
            }

            return bestSum;
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
