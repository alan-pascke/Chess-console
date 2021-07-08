using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class Knight : ChessPiece
    {
        public Knight(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "Knt";
        }
    }
}

