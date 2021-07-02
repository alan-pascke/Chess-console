using System;
using chessboard;

namespace Chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard(8, 8);

            Screen.printChessBoard(chessBoard);

        }
    }
}
