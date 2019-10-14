using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] chessBoard = new int[size, size];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = symbols[col];
                }
            }

            int killerRow = 0;
            int killerCol = 0;
            int removedKnight = 0;

            while (true)
            {
                int maxAttack = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightsAttcks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currentKnightsAttcks++;
                            }
                        }
                        if (currentKnightsAttcks > maxAttack)
                        {
                            maxAttack = currentKnightsAttcks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }
                if (maxAttack > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    removedKnight++;
                }
                else
                {
                    Console.WriteLine(removedKnight);
                    break;
                }
            }
        }

        private static bool IsInside(int[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
                col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
