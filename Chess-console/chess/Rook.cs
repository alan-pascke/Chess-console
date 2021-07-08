using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class Rook : ChessPiece
    {
        public Rook(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "Rok";
        }
    }
}

