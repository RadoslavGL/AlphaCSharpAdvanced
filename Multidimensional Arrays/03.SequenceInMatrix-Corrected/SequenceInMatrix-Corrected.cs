using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrix_Corrected
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

            int maxSequence = 1;
            int currentSequence = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    while (row < n && col < m)
                    {
                        if (true)
                        {

                        }
                    }
                }
            }


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
}
