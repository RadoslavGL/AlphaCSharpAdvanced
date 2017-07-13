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

        //static void PrintMatrix(int[,] array)
        //{
        //    for (int row = 0; row < array.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < array.GetLength(1); col++)
        //        {
        //            if (col == (array.GetLength(1) - 1))
        //            {
        //                Console.Write(array[row, col]);

        //            }
        //            else
        //            {
        //                Console.Write("{0} ", array[row, col]);
        //            }
        //        }

        //        Console.WriteLine();
        //    }
        //}

        public static int SumMovements(int currentPositionX, int currentPositionY,
            int[,] matrix, bool[,] matrixBool)
        {
            int sumMoves = 0;
            int changeInDirection = int.Parse(Console.ReadLine());

            for (int i = 0; i < changeInDirection; i++)
            {
                string[] directionAndMoves = Console.ReadLine().Split(' ');
                string direction = directionAndMoves[0];
                int moves = int.Parse(directionAndMoves[1]);

                switch (direction)
                {
                    case "UR":
                    case "RU": MoveUpRight(currentPositionX, currentPositionY, sumMoves, moves, matrix, matrixBool); break;
                    case "LU":
                    case "UL": MoveUpLeft(currentPositionX, currentPositionY, sumMoves, moves, matrix, matrixBool); break;
                    case "DL":
                    case "LD": MoveDownRight(currentPositionX, currentPositionY, sumMoves, moves, matrix, matrixBool); break;
                    case "DR":
                    case "RD": MoveDownLeft(currentPositionX, currentPositionY, sumMoves, moves, matrix, matrixBool); break;
                    default:
                        break;
                }
            }
            return sumMoves;
                
        }
        public static int MoveUpRight(int currentPositionX, int currentPositionY,
            int sumMoves, int moves, int[,] matrix, bool[,] matrixBool)
        {
            while (currentPositionX > 0 && currentPositionY < matrix.GetLength(1) - 1 && moves > 0)
            {
                moves--;
                currentPositionX--;
                currentPositionY++;
                if (matrixBool[currentPositionX, currentPositionY] == false)
                {
                    sumMoves += matrix[currentPositionX, currentPositionY];
                    matrixBool[currentPositionX, currentPositionY] = true;
                }

            }

            return sumMoves;
        }

        public static int MoveUpLeft(int currentPositionX, int currentPositionY,
            int sumMoves, int moves, int[,] matrix, bool[,] matrixBool)
        {
            while (currentPositionX > 0 && currentPositionY > 0 && moves > 0)
            {
                moves--;
                currentPositionX--;
                currentPositionY--;
                if (matrixBool[currentPositionX, currentPositionY] == false)
                {
                    sumMoves += matrix[currentPositionX, currentPositionY];
                    matrixBool[currentPositionX, currentPositionY] = true;
                }

            }
            return sumMoves;
        }

        public static int MoveDownRight(int currentPositionX, int currentPositionY,
            int sumMoves, int moves, int[,] matrix, bool[,] matrixBool)
        {
            while (currentPositionX < matrix.GetLength(0) - 1 
                && currentPositionY < matrix.GetLength(1) - 1 && moves > 0)
            {
                moves--;
                currentPositionX++;
                currentPositionY++;
                if (matrixBool[currentPositionX, currentPositionY] == false)
                {
                    sumMoves += matrix[currentPositionX, currentPositionY];
                    matrixBool[currentPositionX, currentPositionY] = true;
                }

            }
            return sumMoves;
        }

        public static int MoveDownLeft(int currentPositionX, int currentPositionY,
            int sumMoves, int moves, int[,] matrix, bool[,] matrixBool)
        {
            while (currentPositionX < matrix.GetLength(0) - 1
                && currentPositionY > 0 && moves > 0)
            {
                moves--;
                currentPositionX++;
                currentPositionY--;
                if (matrixBool[currentPositionX, currentPositionY] == false)
                {
                    sumMoves += matrix[currentPositionX, currentPositionY];
                    matrixBool[currentPositionX, currentPositionY] = true;
                }

            }
            return sumMoves;
        }

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            int[,] matrix = new int[n, m];

            FillTheMatrix(matrix);
            //PrintMatrix(matrix);

            int currentPositionX = matrix.GetLength(0) - 1;
            int currentPositionY = 0;

            bool[,] matrixBool = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            

            Console.WriteLine(SumMovements(currentPositionX, currentPositionY, matrix, matrixBool));

        }
    }
}
