//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;
using System.Linq;

class LargestAreaInMatrix
{
    static void Main(string[] args)
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(dimensions[0]);
        int m = Convert.ToInt32(dimensions[1]);

        int[,] matrix = new int[n, m];

        FillTheMatrix(matrix);

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
}

