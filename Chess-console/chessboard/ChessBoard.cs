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
        public ChessPiece piece(int line, int column)
        {
            return chessPieces[line, column];
        }
        public void PieceInsertion(ChessPiece piece, Position position)
        {
            //Aqui está buscando uma posição que foi digitada e inserindo uma peça nesta posição
            chessPieces[position.line, position.column] = piece;

            //Abaixo irá atualizar a posição da peça:
            //posição da peça irá mudar para a posição que está definida acima em
            //"chessPieces[position.line, position.column]"
            piece.position = position;
        }
    }
}
