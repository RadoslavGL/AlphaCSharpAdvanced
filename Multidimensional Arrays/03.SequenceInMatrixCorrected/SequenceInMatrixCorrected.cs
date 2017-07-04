using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrixCorrected
{
    class SequenceInMatrixCorrected
    {
        static void Main(string[] args)
        {
            string[] dimString = Console.ReadLine().Split(' ');
            int n = int.Parse(dimString[0]);
            int m = int.Parse(dimString[1]);

            string[,] matrix = new string[n, m];
            FillTheMatrix(matrix);



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
}
