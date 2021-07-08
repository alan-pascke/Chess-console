using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class Queen: ChessPiece
    {
        public Queen(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "Qen";
        }
    }
}
