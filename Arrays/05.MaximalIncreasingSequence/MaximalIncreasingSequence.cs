using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumb = new int[n];

            FillTheArray(arrNumb);

            int maxSequence = FindMaxSequence(arrNumb);
            Console.WriteLine(maxSequence);
        }

        public static void FillTheArray(int[] arrNumb)
        {
            for (int i = 0; i < arrNumb.Length; i++)
            {
                arrNumb[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int FindMaxSequence(int[] arrNumb)
        {
            int currentSeq = 1;
            int maxSeq = 1;

            for (int j = 1; j < arrNumb.Length; j++)
            {
                if (arrNumb[j] > arrNumb[j - 1])
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

            return maxSeq;

        }
    }
}
