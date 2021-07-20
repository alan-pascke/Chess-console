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
        private bool canToMove(Position position)
        {
            ChessPiece chessPiece = chessBoard.piece(position);
            return chessPiece == null || chessPiece.color != color;
        }


        public override bool[,] possibleMoves()
        {
            bool[,] matrix = new bool[chessBoard.lines, chessBoard.columns];

            Position position = new Position(0, 0);

            //nort east
            position.valueDefinition(position.line - 1, position.column + 1);
            while (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
                if (chessBoard.piece(position) != null && chessBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line - 1;
                position.column = position.column + 1;
                
            }
            //southeast
            position.valueDefinition(position.line + 1, position.column + 1);
            while(chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
                if (chessBoard.piece(position) != null && chessBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line + 1;
                position.column = position.column + 1;
            }
            //south-west
            position.valueDefinition(position.line + 1, position.column - 1);
            while (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
                if (chessBoard.piece(position) != null && chessBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line + 1;
                position.column = position.column - 1;
            }
            //northwest
            position.valueDefinition(position.line - 1, position.column - 1);
            while (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
                if (chessBoard.piece(position) != null && chessBoard.piece(position).color != color)
                {
                    break;
                }
                position.line = position.line - 1;
                position.column = position.column - 1;
            }

            return matrix;
        }
    }
}
