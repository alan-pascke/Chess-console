using System;
using chessboard;
using chess;

namespace Chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //ChessPosition chessPosition = new ChessPosition('a', 1);

                //Console.WriteLine(chessPosition);

                //Console.WriteLine(chessPosition.toPosition());



                ChessBoard chessBoard = new ChessBoard(8, 8);

                chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new Position(0, 0));
                chessBoard.PieceInsertion(new Knight(chessBoard, Color.Black), new Position(0, 1));
                chessBoard.PieceInsertion(new Bishop(chessBoard, Color.Black), new Position(0, 2));
                chessBoard.PieceInsertion(new Queen(chessBoard, Color.Black), new Position(0, 3));
                chessBoard.PieceInsertion(new King(chessBoard, Color.Black), new Position(0, 4));
                chessBoard.PieceInsertion(new Bishop(chessBoard, Color.Black), new Position(0, 5));
                chessBoard.PieceInsertion(new Knight(chessBoard, Color.Black), new Position(0, 6));
                chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new Position(0, 7));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 0));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 1));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 2));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 3));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 4));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 5));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 6));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new Position(1, 7));

                chessBoard.PieceInsertion(new Rook(chessBoard, Color.White), new Position(7, 0));
                chessBoard.PieceInsertion(new Knight(chessBoard, Color.White), new Position(7, 1));
                chessBoard.PieceInsertion(new Bishop(chessBoard, Color.White), new Position(7, 2));
                chessBoard.PieceInsertion(new Queen(chessBoard, Color.White), new Position(7, 3));
                chessBoard.PieceInsertion(new King(chessBoard, Color.White), new Position(7, 4));
                chessBoard.PieceInsertion(new Bishop(chessBoard, Color.White), new Position(7, 5));
                chessBoard.PieceInsertion(new Knight(chessBoard, Color.White), new Position(7, 6));
                chessBoard.PieceInsertion(new Rook(chessBoard, Color.White), new Position(7, 7));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 0));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 1));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 2));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 3));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 4));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 5));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 6));
                chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new Position(6, 7));

                Screen.printChessBoard(chessBoard);


            }
            catch (ChessboardExeption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
