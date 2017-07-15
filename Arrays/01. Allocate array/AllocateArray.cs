using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_array
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
