//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix and prints its length.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
    static void Main(string[] args)
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(dimensions[0]);
        int m = Convert.ToInt32(dimensions[1]);

        string[,] matrix = new string[n, m];

        FillTheMatrix(matrix);

        int maxLDiagSeq = LeftDiagonalSeq(matrix);
        int maxRDiagSeq = RightDiagonalSeq(matrix);
        int maxRow = RowSeq(matrix);
        int maxCol = ColSeq(matrix);

        Console.WriteLine(MaxSequence(maxLDiagSeq, maxRDiagSeq, maxRow, maxCol));
    }

    public static void FillTheMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = input[col];
            }
        }
    }

    public static int LeftDiagonalSeq(string[,] matrix)
    {
        int maxSequence = 1;
        int currentSequence = 1;

        int indexRow = matrix.GetLength(0) - 1;
        int indexCol = 0;

        int step = 1;

        while (step < (matrix.GetLength(0) + matrix.GetLength(1)))
        {
            if (indexRow != 0)
            {
                currentSequence = MaxLDiagonal(matrix, indexRow, indexCol);
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                indexRow--;
                step++;
            }
            else
            {
                currentSequence = MaxLDiagonal(matrix, indexRow, indexCol);
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                indexCol++;
                step++;
            }
        }
       
        return maxSequence;
    }

    public static int MaxLDiagonal(string[,] matrix, int indexRow, int indexCol)
    {
        int max = 1;
        int currentMax = 1;

        while (indexRow < (matrix.GetLength(0) - 1) && indexCol < (matrix.GetLength(1) -1) 
            && indexRow > -1 
            && indexCol > -1)
        {
            if (matrix[indexRow, indexCol] == matrix[indexRow + 1, indexCol + 1])
            {
                currentMax++;
                indexRow++;
                indexCol++;
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }
            else
            {
                indexRow++;
                indexCol++;
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }
        }

        return max;
    }

    public static int RightDiagonalSeq(string[,] matrix)
    {
        int maxSequence = 1;
        int currentSequence = 1;

        int indexRow = matrix.GetLength(0) - 1;
        int indexCol = matrix.GetLength(1) - 1;

        int step = 1;

        while (step < (matrix.GetLength(0) + matrix.GetLength(1)))
        {
            if (indexRow != 0)
            {
                currentSequence = MaxRDiagonal(matrix, indexRow, indexCol);
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                indexRow--;
                step++;
            }
            else
            {
                currentSequence = MaxRDiagonal(matrix, indexRow, indexCol);
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                indexCol--;
                step++;
            }
        }

        return maxSequence;
    }

    public static int MaxRDiagonal(string[,] matrix, int indexRow, int indexCol)
    {
        int max = 1;
        int currentMax = 1;

        while (indexRow < (matrix.GetLength(0) - 1) && indexCol < (matrix.GetLength(1) - 1)
            && indexRow > -1
            && indexCol > -1)
        {
            if (matrix[indexRow, indexCol] == matrix[indexRow + 1, indexCol + 1])
            {
                currentMax++;
                indexRow++;
                indexCol--;
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }
            else
            {
                indexRow++;
                indexCol--;
                if (currentMax > max)
                {
                    max = currentMax;
                }
                currentMax = 1;
            }
        }

        return max;
    }

    public static int RowSeq(string[,] matrix)
    {
        int max = 1;
        int currentMax = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    currentMax++;
                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                }
                else
                {
                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                    currentMax = 1;
                }
            }
        }


        return max;
    }

    public static int ColSeq(string[,] matrix)
    {
        int max = 1;
        int currentMax = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    currentMax++;
                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                }
                else
                {
                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                    currentMax = 1;
                }
            }
        }


        return max;

    }

    public static int MaxSequence(int maxLDiagSeq, int maxRDiagSeq, int maxRow, int maxCol)
    {
        int maxSeq = 0;

        int[] seqArr = new int[] { maxLDiagSeq, maxRDiagSeq, maxRow, maxCol };
        Array.Sort(seqArr);
        maxSeq = seqArr[3];

        return maxSeq;
    }
}

