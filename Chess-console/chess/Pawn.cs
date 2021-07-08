using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class Pawn : ChessPiece
    {
        public Pawn(ChessBoard chessBoard, Color color) : base(chessBoard, color)
        {

        }
        public override string ToString()
        {
            return "Pwn";
        }
    }
}
