using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int leftDiagonal = 0;
            int rightDiagonal = 0;
            int colCount = 0;

            int leftResult = LeftDiagonal(matrix, leftDiagonal, colCount);

            colCount = 0;

            int rightResult = RightDiagonal(matrix, rightDiagonal, colCount);


            Console.WriteLine(Math.Abs(leftResult - rightResult));

        }

        private static int RightDiagonal(int[,] matrix, int rightDiagonal, int colCount)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                rightDiagonal += matrix[row, colCount];
                colCount++;
            }
            return rightDiagonal;
        }

        private static int LeftDiagonal(int[,] matrix, int leftDiagonal, int colCount)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                leftDiagonal += matrix[row, colCount];
                colCount++;
            }

            return leftDiagonal;
        }
    }
}
