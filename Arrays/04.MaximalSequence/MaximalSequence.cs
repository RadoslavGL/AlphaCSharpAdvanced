using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArr = new int[n];

            FillArray(numArr);

            int currentSeq = 1;
            int maxSeq = 1;

            for (int j = 1; j < numArr.Length; j++)
            {
                if (numArr[j] == numArr[j-1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                }
            }

            Console.WriteLine(maxSeq);
        }

        private static void FillArray(int[] numArr)
        {
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
