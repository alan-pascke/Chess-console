using System;
using chessboard;
using chess;

namespace Chess_console
{
    class Screen
    {
        public static void printChessBoard(ChessBoard chessBoard)
        {
            for (int i = 0; i < chessBoard.lines; i++)
            {
                System.Console.Write(8 - i + " | ");
                for (int j = 0; j < chessBoard.columns; j++)
                {
                    printChessPiece(chessBoard.piece(i, j));
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.Write("     A     B     C     D     " +
                "E     F     G     H");
        }
        public static void printChessBoard(ChessBoard chessBoard, bool[,] possiblePositions)
        {
            ConsoleColor originBackGround = Console.BackgroundColor;
            ConsoleColor changeBackGrnd = ConsoleColor.Gray;

            for (int i = 0; i < chessBoard.lines; i++)
            {
                System.Console.Write(8 - i + " | ");
                for (int j = 0; j < chessBoard.columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = changeBackGrnd;
                    }
                    else
                    {
                        Console.BackgroundColor = originBackGround;
                    }
                    printChessPiece(chessBoard.piece(i, j));
                    Console.BackgroundColor = originBackGround;

                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.Write("     A     B     C     D     " +
                "E     F     G     H");
            Console.BackgroundColor = originBackGround;
        }
        public static void printChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
            {
                System.Console.Write(" -  | ");
            }
            else
            {
                if (chessPiece.color == Color.White)
                {
                    System.Console.Write(chessPiece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(chessPiece);
                    Console.ForegroundColor = aux;

                }
                Console.Write(" | ");
            }

        }
        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }

    }
}
