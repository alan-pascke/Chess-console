using System;
using System.Collections.Generic;
using System.Text;

namespace chessboard
{
    class ChessBoard
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private ChessPiece[,] chessPieces;

        public ChessBoard(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            chessPieces = new ChessPiece[lines, columns] ;
        }
    }
}
