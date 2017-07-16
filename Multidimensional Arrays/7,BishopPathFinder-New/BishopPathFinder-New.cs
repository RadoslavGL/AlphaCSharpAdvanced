using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BishopPathFinder_New
{
    class BishopPathFinder_New
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int height = int.Parse(dimensions[0]);
            int width = int.Parse(dimensions[1]);

            int[,] matrix = new int[height, width];
            FillMatrix(matrix);


            int moves = int.Parse(Console.ReadLine());

            //PrintMatrix(matrix);


            Console.WriteLine(TotalSum(matrix, moves));
        }

        private static void FillMatrix(int[,] matrix)
        {
            int currentRow = matrix.GetLength(0) - 1;
            int currentCol = 0;
            int valueMatrix = 0;
            matrix[currentRow, currentCol] = valueMatrix;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = matrix.GetLength(0) - 1; j > - 1; j--)
                {
                    matrix[j, i] = valueMatrix;
                    valueMatrix += 3;
                }
                valueMatrix = matrix[matrix.GetLength(0) - 1, i] + 3;
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

        private static int TotalSum(int[,] matrix, int moves)
        {
            int currentRow = matrix.GetLength(0) - 1;
            int currentCol = 0;

            int sumMoves = 0;

            for (int i = 0; i < moves; i++)
            {
                string[] inputMoves = Console.ReadLine().Split(' ');
                string direction = inputMoves[0];
                int steps = int.Parse(inputMoves[1]) - 1;


                switch (direction)
                {
                    case "UR":
                    case "RU":
                        while (currentRow > 0 && currentCol < (matrix.GetLength(1) - 1) && steps > 0)
                        {
                            steps--;

                            currentRow--;
                            currentCol++;
                            sumMoves += matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        break;
                    case "LU":
                    case "UL":
                        while (currentRow > 0 && currentCol > 0 && steps > 0)
                        {
                            steps--;
                            currentRow--;
                            currentCol--;
                            sumMoves += matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        break;
                    case "DL":
                    case "LD":
                        while (currentRow < (matrix.GetLength(0) - 1) && currentCol > 0 && steps > 0)
                        {
                            steps--;
                            currentRow++;
                            currentCol--;
                            sumMoves += matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        break;
                    case "DR":
                    case "RD":
                        while (currentRow < (matrix.GetLength(0) - 1) && currentCol < (matrix.GetLength(1) - 1) && steps > 0)
                        {
                            steps--;
                            currentRow++;
                            currentCol++;
                            sumMoves += matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        break;
                }

            }
            return sumMoves;
        }

        

        
    }
}
