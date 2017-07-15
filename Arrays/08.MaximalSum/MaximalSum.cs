using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);
            Console.WriteLine(MaxSumSeqElements(numbArr));
        }

        public static int MaxSumSeqElements(int[] numbArr)
        {
            int maxSum = 0;
            int currentSum = 0;

            for (int j = 0; j < numbArr.Length; j++)
            {
                if (currentSum + numbArr[j] > numbArr[j])
                {
                    currentSum += numbArr[j];
                }
                else
                {
                    currentSum = numbArr[j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

            }

            return maxSum;
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
