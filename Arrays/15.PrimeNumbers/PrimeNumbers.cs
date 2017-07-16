using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] isNonPrime = new bool[n + 1];

            for (int i = 2; i < Math.Sqrt(isNonPrime.Length); i++)
            {
                if (isNonPrime[i] == false)
                {
                    for (int j = i*i; j < isNonPrime.Length; j += i)
                    {
                        isNonPrime[j] = true;
                    }
                }
            }

            bool isFound = false;

            while (isFound == false)
            {
                if (isNonPrime[n] == false)
                {
                    Console.WriteLine(n);
                    isFound = true;
                }
                else
                {
                    n--;
                }
            }

        }
    }
}
