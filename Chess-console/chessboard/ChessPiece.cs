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
        public ChessPiece chessPiece { get; set; }

        public ChessPiece(Position position, Color color,  ChessPiece chessPiece)
        {
            this.position = position;
            this.color = color;
            this.numberOfmoves = 0;
            this.chessPiece = chessPiece;
        }
    }
}
