using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SneakyTheSnake
{
    class SneakyTheSnake
    {
        static void Main(string[] args)
        {
            string dimensions = Console.ReadLine();
            char[] splitters = new char[] { 'x' };
            string[] dimensionsArr = dimensions.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimensionsArr[0]);
            int cols = int.Parse(dimensionsArr[1]);

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] colInput = Console.ReadLine().ToCharArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = colInput[j];
                }
            }

            string directionsStr = Console.ReadLine();
            char[] splitters2 = new char[] { ',' };
            string[] temp =  directionsStr.Split(splitters2, StringSplitOptions.RemoveEmptyEntries);
            char[] directions = new char[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                directions[i] = char.Parse(temp[i]);
            }
            //PrintMatrix(matrix);
            //Console.WriteLine(string.Join("\n", directions));

            char[] entryRow = new char[cols];
            for (int i = 0; i < cols; i++)
            {
                entryRow[i] = matrix[0, i];
            }

            int currentRow = 0;
            int currentCol = Array.IndexOf(entryRow, 'e');

            int steps = 0;
            int maxSteps = directions.Length;
            int length = 3;
            bool isOut = false;
            bool isHit = false;
            bool isLost = false;
            bool isStuck = false;
            bool isStarved = false;

            while (!isOut && !isHit && !isLost && !isStuck && !isStarved)
            {
                switch (directions[steps])
                {
                    case 's':
                        currentRow++;
                        steps++;
                        Checks(matrix, currentRow, ref currentCol, steps, maxSteps, ref length, ref isOut, ref isHit, ref isLost, ref isStuck, ref isStarved);
                        break;

                    case 'd':
                        currentCol++;
                        steps++;
                        Checks(matrix, currentRow, ref currentCol, steps, maxSteps, ref length, ref isOut, ref isHit, ref isLost, ref isStuck, ref isStarved);
                        break;

                    case 'w':
                        currentRow--;
                        steps++;
                        Checks(matrix, currentRow, ref currentCol, steps, maxSteps, ref length, ref isOut, ref isHit, ref isLost, ref isStuck, ref isStarved);
                        break;

                    case 'a':
                        currentCol--;
                        steps++;
                        Checks(matrix, currentRow, ref currentCol, steps, maxSteps, ref length, ref isOut, ref isHit, ref isLost, ref isStuck, ref isStarved);
                        break;
                }
            }

            if (isOut)
            {
                Console.WriteLine("Sneaky is going to get out with length {0}", length);
            }

            if (isHit)
            {
                Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", currentRow, currentCol);
            }

            if (isLost)
            {
                Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", length);
            }

            if (isStuck)
            {
                Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", currentRow, currentCol);
            }

            if (isStarved)
            {
                Console.WriteLine("Sneaky is going to starve at [{0},{1}]", currentRow, currentCol);
            }

        }

        private static void Checks(char[,] matrix, int currentRow, ref int currentCol, int steps, int maxSteps, ref int length, ref bool isOut, ref bool isHit, ref bool isLost, ref bool isStuck, ref bool isStarved)
        {
            //length--
            if (steps % 5 == 0)
            {
                length--;
            }

            //left or right outside array
            if (currentCol == matrix.GetLength(1))
            {
                currentCol = 0;
            }

            if (currentCol == -1)
            {
                currentCol = matrix.GetLength(1) - 1;
            }

            //eggs
            if (matrix[currentRow, currentCol] == '@')
            {
                length++;
                matrix[currentRow, currentCol] = '-';
            }

            //lost - outside array
            if (currentRow >= matrix.GetLength(0))
            {
                isLost = true;
                return;
            }

            //out / == 'e'
            if (matrix[currentRow, currentCol] == 'e')
            {
                isOut = true;
                return;
            }

            //hit / == '%'
            if (matrix[currentRow, currentCol] == '%')
            {
                isHit = true;
                return;
            }

            //stuck - no more steps
            if (steps == maxSteps && !isOut)
            {
                isStuck = true;
                return;
            }

            //starved
            if (length == 0)
            {
                isStarved = true;
                return;
            }
        }

        //public static void PrintMatrix(char[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(matrix[row, col]);
        //        }
        //        Console.ReadLine();
        //    }
        //}
    }
    }
