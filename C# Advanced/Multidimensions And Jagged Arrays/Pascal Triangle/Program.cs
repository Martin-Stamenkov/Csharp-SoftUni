using System;
using System.Linq;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());

            long[][] matrix = new long[rows][];
            matrix[0] = new long[1];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new long[row + 1];
                matrix[row][0] = 1;
                matrix[row][matrix[row].Length - 1] = 1;

                for (int i = 1; i < matrix[row].Length - 1; i++)
                {
                    matrix[row][i] +=
                    matrix[row - 1][i] +
                    matrix[row - 1][i - 1];

                }

            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
