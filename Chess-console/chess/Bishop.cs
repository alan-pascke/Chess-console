using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class Bishop : ChessPiece
    {
        public Bishop(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "Bis";
        }
    }
}
