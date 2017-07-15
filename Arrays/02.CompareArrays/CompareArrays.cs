using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < arrOne.Length; i++)
            {
                arrOne[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrTwo[i] = int.Parse(Console.ReadLine());
            }
            

            bool isEqual = true;
            for (int i = 0; i < n; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
