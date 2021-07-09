using System;
using System.Collections.Generic;
using System.Text;


namespace chessboard
{
    class ChessPiece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int numberOfmoves { get; protected set; }
        public ChessBoard chessBoard { get; set; }

        public ChessPiece(ChessBoard chessBoard ,Color color)
        {
            this.position = null;
            this.color = color;
            this.numberOfmoves = 0;
            this.chessBoard = chessBoard;
        }

        public void incrementMovements()
        {
            numberOfmoves++;
        }

    }
}
