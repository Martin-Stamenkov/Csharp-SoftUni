using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                matrix[row] = currentRow;
            }

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row].Length == matrix[row+1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row+1].Length; col++)
                    {
                        matrix[row+1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (!IsTrue(matrix, row, col))
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (currentCommand == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (currentCommand == "Subtract")
                {
                    matrix[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            Print(matrix);
        }

        private static bool IsTrue(double[][] matrix, int row,int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
          
        }

        private static void Print(double[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
