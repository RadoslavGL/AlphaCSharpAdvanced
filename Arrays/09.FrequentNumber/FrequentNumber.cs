using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbArr = new int[n];

            FillTheArray(numbArr);
            SelSort(numbArr);
            MostFrequent(numbArr);

        }

        public static void FillTheArray(int[] numbArr)
        {
            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = int.Parse(Console.ReadLine());
            }

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

        public static void MostFrequent(int[] numbArr)
        {
            int currentOccurrences = 1;
            int maxOccurrences = 1;
            int mostFreqNumber = 0;

            for (int i = 1; i < numbArr.Length; i++)
            {
                if (numbArr[i] == numbArr[i - 1])
                {
                    currentOccurrences++;
                }
                else
                {
                    currentOccurrences = 1;
                }

                if (currentOccurrences > maxOccurrences)
                {
                    maxOccurrences = currentOccurrences;
                    mostFreqNumber = numbArr[i - 1];
                }
            }

            Console.WriteLine("{0} ({1} times)", mostFreqNumber, maxOccurrences);

        }
    }
}
