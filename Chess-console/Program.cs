using System;
using chessboard;
using chess;

namespace Chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard(8, 8);

            chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new Position(0, 0));
            chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new Position(1, 3));
            chessBoard.PieceInsertion(new King(chessBoard, Color.Black), new Position(2, 4));

            Screen.printChessBoard(chessBoard);

        }
    }
}
