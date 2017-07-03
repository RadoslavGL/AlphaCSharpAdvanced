//https://gitlab.com/TelerikAcademy/alpha/tree/master/C%23-Advanced/Multidimensional-Arrays/tasks/02.%20Maximal%20sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
//that has maximal sum of its elements.
//Print that sum.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string dimensions = Console.ReadLine();
            int[] dimArr = dimensions.Split(' ').Select(x => int.Parse(x)).ToArray();
            int n = dimArr[0];
            int m = dimArr[1];
            int[,] matrix = new int[n, m];
            FillTheMatrix(matrix);
            //PrintMatrix(matrix);

            Console.WriteLine(MaxSumOf3(matrix)); 

        }

        public static void FillTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                int[] rowInput = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int MaxSumOf3(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int currentSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col +1];

                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }

    }
}
