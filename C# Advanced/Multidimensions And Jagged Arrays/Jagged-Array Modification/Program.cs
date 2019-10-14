using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currenRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                matrix[row] = currenRow;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(" ");
                string currentCommand = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (currentCommand == "Add")
                {
                    if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix.Length)
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                    else
                    {
                        matrix[row][col] += value;

                    }
                }
                else if (currentCommand == "Subtract")
                {
                    if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix.Length)
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                    else
                    {
                        matrix[row][col] -= value;

                    }
                }

                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
