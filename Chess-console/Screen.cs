using System;
using chessboard;
using chess;

namespace Chess_console
{
    class Screen
    {
        public static void printChessBoard( ChessBoard chessBoard)
        {
            for (int i = 0; i < chessBoard.lines; i++)
            {
                System.Console.Write(8 - i + "  | ");
                for (int j = 0; j < chessBoard.columns; j++)
                {
                    if (chessBoard.piece(i, j) == null)
                    {
                        System.Console.Write(" -  | ");
                    }
                    else 
                    {
                        printChessBoard(chessBoard.piece(i, j));
                        Console.Write(" | ");
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.Write("      A     B     C     D     " +
                "E     F     G     H");
        }
        public static void printChessBoard(ChessPiece chessPiece)
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
