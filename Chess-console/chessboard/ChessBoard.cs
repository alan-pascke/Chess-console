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

        public ChessPiece piece (Position position)
        {
            return chessPieces[position.line, position.column];
        }
        public void PieceInsertion(ChessPiece piece, Position position)
        {
            if (PieceExist(position))
            {
                throw new ChessboardExeption("there is a piece on this position");
            }
            else
            {
                //Aqui está inserindo uma peça na posição que chegou como parametro
                chessPieces[position.line, position.column] = piece;

                //Abaixo irá atualizar a posição da peça:
                //posição da peça irá mudar para a posição que está definida acima em
                //"chessPieces[position.line, position.column]"
                piece.position = position;
            }
        }

        //verificar se existe alguma peça na posição
        public bool PieceExist(Position position)
        {
            validatePosition(position);
            return piece(position) != null;
        }

        // retorna mensagem de erro caso a posição seja invalida
        public void validatePosition(Position position)
        {
            if (!truePosition(position))
            {
                throw new ChessboardExeption("Invalid position");
            }
        }

        // testando se a posição é valida
        public bool truePosition(Position position)
        {
            if (position.line < 0|| position.line >= lines 
                || position.column <0 || position.column >= columns)
            {
                return false;
            }
            return true;
        }
        //o método abaixo remove a peça  de uma determinada posição
        public ChessPiece removePiece(Position position)
        {
            if (piece(position) == null)
            {
                return null;
            }
            ChessPiece aux = piece(position);
            aux.position = null;
            chessPieces[position.line, position.column] = null;
            return aux;
        }

    }
}
