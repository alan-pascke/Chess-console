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
        private bool canToMove(Position position)
        {
            ChessPiece chessPiece = chessBoard.piece(position);
            return chessPiece == null || chessPiece.color != color;
        }


        public override bool[,] possibleMoves()
        {
            bool[,] matrix = new bool[chessBoard.lines, chessBoard.columns];

            Position position = new Position(0, 0);

            //nort
            position.valueDefinition(position.line - 1, position.column);
            if (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
            }
            //nort east
            position.valueDefinition(position.line - 1, position.column + 1);
            if (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
            }
            //northwest
            position.valueDefinition(position.line - 1, position.column - 1);
            if (chessBoard.truePosition(position) && canToMove(position))
            {
                matrix[position.line, position.column] = true;
            }

            return matrix;

        }
    }
}
