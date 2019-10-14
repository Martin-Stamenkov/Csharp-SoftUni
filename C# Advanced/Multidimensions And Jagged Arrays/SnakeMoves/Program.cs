using System;
using System.Collections.Generic;
using System.Linq;

namespace _2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            char[] snake = Console.ReadLine().ToCharArray();

            char[,] matrix = new char[rows,cols];

            int count = 0;

            CheckSnake(matrix, snake,count);

            Print(matrix, rows, cols);

        }

        private static void Print(char[,] matrix, int rows, int cols)
        {

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void CheckSnake(char[,] matrix, char[] snake,int count)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[count++];

                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[count++];

                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }
                }

            }
        }
    }
}