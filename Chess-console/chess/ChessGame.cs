using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class ChessGame
    {
        public ChessBoard chessBoard { get; set; }
        private int turn;
        private Color actualPlayer;
        public bool finished { get ; private set; }

        public ChessGame()
        {
            this.chessBoard = new ChessBoard(8,8);
            this.turn = 1;
            this.actualPlayer = Color.White;
            finished = false;
            inputPieces();
        }

        public void movement(Position origin, Position destiny)
        {
            ChessPiece piece = chessBoard.removePiece(origin);
            piece.incrementMovements();
            ChessPiece capturadPiece = chessBoard.removePiece(destiny);
            chessBoard.PieceInsertion(piece, destiny);

        }

        private void inputPieces()
        {

            chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new ChessPosition('a', 1).toPosition());
            chessBoard.PieceInsertion(new Knight(chessBoard, Color.Black), new ChessPosition('b', 1).toPosition());
            chessBoard.PieceInsertion(new Bishop(chessBoard, Color.Black), new ChessPosition('c', 1).toPosition());
            chessBoard.PieceInsertion(new Queen(chessBoard, Color.Black), new ChessPosition('d', 1).toPosition());
            chessBoard.PieceInsertion(new King(chessBoard, Color.Black), new ChessPosition('e', 1).toPosition());
            chessBoard.PieceInsertion(new Bishop(chessBoard, Color.Black), new ChessPosition('f', 1).toPosition());
            chessBoard.PieceInsertion(new Knight(chessBoard, Color.Black), new ChessPosition('g', 1).toPosition());
            chessBoard.PieceInsertion(new Rook(chessBoard, Color.Black), new ChessPosition('h', 1).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('a', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('b', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('c', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('d', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('e', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('f', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('g', 2).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.Black), new ChessPosition('h', 2).toPosition());


            chessBoard.PieceInsertion(new Rook(chessBoard, Color.White), new ChessPosition('a', 8).toPosition());
            chessBoard.PieceInsertion(new Knight(chessBoard, Color.White), new ChessPosition('b', 8).toPosition());
            chessBoard.PieceInsertion(new Bishop(chessBoard, Color.White), new ChessPosition('c', 8).toPosition());
            chessBoard.PieceInsertion(new Queen(chessBoard, Color.White), new ChessPosition('d', 8).toPosition());
            chessBoard.PieceInsertion(new King(chessBoard, Color.White), new ChessPosition('e', 8).toPosition());
            chessBoard.PieceInsertion(new Bishop(chessBoard, Color.White), new ChessPosition('f', 8).toPosition());
            chessBoard.PieceInsertion(new Knight(chessBoard, Color.White), new ChessPosition('g', 8).toPosition());
            chessBoard.PieceInsertion(new Rook(chessBoard, Color.White), new ChessPosition('h', 8).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('a', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('b', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('c', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('d', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('e', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('f', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('g', 7).toPosition());
            chessBoard.PieceInsertion(new Pawn(chessBoard, Color.White), new ChessPosition('h', 7).toPosition());



        }

    }
}
