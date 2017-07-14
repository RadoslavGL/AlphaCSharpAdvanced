using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BishopPathFinder_New
{
    class BishopPathFinder_New
    {
        private static void FillMatrix(int[,] matrix)
        {
            int currentX = matrix.GetLength(0) - 1;
            int currentY = 0;
            int valueMatrix = 0;
            matrix[currentX, currentY] = valueMatrix;
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

        private static void TotalSum(int[,] matrix, int moves, ref int currentX, ref int currentY, ref int sumMoves)
        {
            for (int i = 0; i < moves; i++)
            {
                string[] inputMoves = Console.ReadLine().Split(' ');
                string direction = inputMoves[0];
                int steps = int.Parse(inputMoves[1]) - 1;


                switch (direction)
                {
                    case "UR":
                    case "RU":
                        while (currentX > 0 && currentY < (matrix.GetLength(1) - 1) && steps > 0)
                        {
                            steps--;

                            currentX--;
                            currentY++;
                            sumMoves += matrix[currentX, currentY];
                            matrix[currentX, currentY] = 0;
                        }
                        break;
                    case "LU":
                    case "UL":
                        while (currentX > 0 && currentY > 0 && steps > 0)
                        {
                            steps--;
                            currentX--;
                            currentY--;
                            sumMoves += matrix[currentX, currentY];
                            matrix[currentX, currentY] = 0;
                        }
                        break;
                    case "DL":
                    case "LD":
                        while (currentX < (matrix.GetLength(0) - 1) && currentY > 0 && steps > 0)
                        {
                            steps--;
                            currentX++;
                            currentY--;
                            sumMoves += matrix[currentX, currentY];
                            matrix[currentX, currentY] = 0;
                        }
                        break;
                    case "DR":
                    case "RD":
                        while (currentX < (matrix.GetLength(0) - 1) && currentY < (matrix.GetLength(1) - 1) && steps > 0)
                        {
                            steps--;
                            currentX++;
                            currentY++;
                            sumMoves += matrix[currentX, currentY];
                            matrix[currentX, currentY] = 0;
                        }
                        break;
                    default:
                        break;
                }

            }

        }

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            int[,] matrix = new int[n, m];
            FillMatrix(matrix);


            int moves = int.Parse(Console.ReadLine());

            int currentX = matrix.GetLength(0) - 1;
            int currentY = 0;
            int sumMoves = 0;
            TotalSum(matrix, moves, ref currentX, ref currentY, ref sumMoves);

            //PrintMatrix(matrix);


            Console.WriteLine(sumMoves);
        }

        
    }
}
