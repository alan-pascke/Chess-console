using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class King : ChessPiece
    {
        public King(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "King";
        }
    }
}
