using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BishopPathFinder
{
    class BishopPathFinder
    {
        public static void FillTheMatrix(int[,] matrix)
        {
            int currentRow = matrix.GetLength(0) - 1;
            int currentCol = 0;
            matrix[currentRow, currentCol] = 0;
            int currentValue = 0;
            while (currentRow > 0)
            {
                currentRow--;
                currentValue += 3;
                matrix[currentRow, currentCol] = currentValue;
                FillTheDiagonal(matrix, currentRow, currentCol, currentValue);
            }
            while (currentCol < matrix.GetLength(1) - 1)
            {
                currentCol++;
                currentValue += 3;
                matrix[currentRow, currentCol] = currentValue;
                FillTheDiagonal(matrix, currentRow, currentCol, currentValue);
            }
        }

        public static void FillTheDiagonal(int[,] matrix, int currentRow, int currentCol, int currentValue)
        {
            while (currentRow < (matrix.GetLength(0) - 1) && currentCol < (matrix.GetLength(1) - 1))
            {
                currentRow++;
                currentCol++;
                matrix[currentRow, currentCol] = currentValue;
            }
        }

        static void PrintMatrix(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (col == (array.GetLength(1) - 1))
                    {
                        Console.Write(array[row, col]);

                    }
                    else
                    {
                        Console.Write("{0} ", array[row, col]);
                    }
                }

                Console.WriteLine();
            }
        }

        public static void SumMovements(int[,] matrix, int sumMoves)
        {
            int changeInDirection = int.Parse(Console.ReadLine());
            bool[,] matrixBool = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < changeInDirection; i++)
            {
                string[] directionAndMoves = Console.ReadLine().Split(' ');
                string direction = directionAndMoves[0];
                int moves = int.Parse(directionAndMoves[1]);
                    
            }
        }

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            int[,] matrix = new int[n, m];

            FillTheMatrix(matrix);
            PrintMatrix(matrix);

            int sumMoves = 0;
            SumMovements(matrix, sumMoves);

        }
    }
}
