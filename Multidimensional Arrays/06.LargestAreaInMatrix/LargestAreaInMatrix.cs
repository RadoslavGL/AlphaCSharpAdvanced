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

        int currentArea = 1;
        int largestArea = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int rowIndex = row;
                int colIndex = col;
                currentArea = FindArea(matrix, rowIndex, colIndex);

                if (currentArea > largestArea)
                {
                    largestArea = currentArea;
                }
            }
        }
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

    public static int FindArea(int[,] matrix, int rowIndex, int colIndex)
    {
        int currentArea = 1;
        bool[,] boolMatrix = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        boolMatrix[rowIndex, colIndex] = true;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, colIndex] == matrix[i, j] && boolMatrix[i, j] == false 
                    && )
                {

                }
            }
        }

        return currentArea;
    }
}

