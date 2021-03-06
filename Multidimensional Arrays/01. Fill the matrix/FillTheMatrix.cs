﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_matrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            switch (letter)
            {
                case 'a': FillMatrixA(matrix, n); break;
                case 'b': FillMatrixB(matrix, n); break;
                case 'c': FillMatrixC(matrix, n); break;
                case 'd': FillMatrixD(matrix, n); break;

                default:
                    break;
            }

            PrintMatrix(matrix);

        }

        static void FillMatrixA(int[,] matrix, int n)
        {
            int increment = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = increment++;
                }
            }
        }

        static void FillMatrixB(int[,] matrix, int n)
        {
            int increment = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = increment++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row > -1; row--)
                    {
                        matrix[row, col] = increment++;
                    }
                }

            }
        }

        static void FillMatrixC(int[,] matrix, int n)
        {
            int rowIndex = matrix.GetLength(0) - 1;
            int colIndex = 0;
            int increment = 1;

            while (increment <= n * n)
            {

                if (rowIndex != 0)
                {
                    increment = FillDiagonalMatrixC(matrix, rowIndex, colIndex, increment);
                    rowIndex--;
                }
                else
                {
                    increment = FillDiagonalMatrixC(matrix, rowIndex, colIndex, increment);
                    colIndex++;
                }
            }
        }

        private static int FillDiagonalMatrixC(int[,] matrix, int rowIndex, int colIndex, int increment)
        {
            int row = rowIndex;
            int col = colIndex;
            while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                NewMethod(matrix, ref increment, ref row, ref col);
            }

            return increment;
        }

        private static void NewMethod(int[,] matrix, ref int increment, ref int row, ref int col)
        {
            matrix[row, col] = increment;
            increment++;
            row++;
            col++;
        }

        static void FillMatrixD(int[,] matrix, int n)
        {
            int increment = 1;
            int rowIndex = 0;
            int colIndex = 0;



            //directions

            bool isDown = true;
            bool isRight = false;
            bool isUp = false;
            bool isLeft = false;

            while (increment <= n * n)
            {
                if (isDown)
                {
                    if (isDown && rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1)
                    && rowIndex > -1 && colIndex > -1
                    && matrix[rowIndex, colIndex] == 0)
                    {
                        matrix[rowIndex, colIndex] = increment++;
                        rowIndex++;
                    }
                    else
                    {
                        isDown = false;
                        isRight = true;
                        rowIndex--;
                        colIndex++;
                    }
                }
                else if (isRight)
                {
                    if (isRight && rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1)
                                        && rowIndex > -1 && colIndex > -1
                                        && matrix[rowIndex, colIndex] == 0)
                    {
                        matrix[rowIndex, colIndex] = increment++;
                        colIndex++;
                    }
                    else
                    {
                        isRight = false;
                        isUp = true;
                        colIndex--;
                        rowIndex--;
                    }
                }
                else if (isUp)
                {
                    if (rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1)
                    && rowIndex > -1 && colIndex > -1
                    && matrix[rowIndex, colIndex] == 0)
                    {
                        matrix[rowIndex, colIndex] = increment++;
                        rowIndex--;
                    }
                    else
                    {
                        isUp = false;
                        isLeft = true;
                        rowIndex++;
                        colIndex--;
                    }
                }
                else if (isLeft)
                {
                    if (rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1)
                    && rowIndex > -1 && colIndex > -1
                    && matrix[rowIndex, colIndex] == 0)
                    {
                        matrix[rowIndex, colIndex] = increment++;
                        colIndex--;
                    }
                    else
                    {
                        isLeft = false;
                        isDown = true;
                        rowIndex++;
                        colIndex++;
                    }
                }

                
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
    }
}
