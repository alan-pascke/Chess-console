using System;
using System.Collections.Generic;
using chessboard;

namespace chessboard
{

    // This class is converting the type :
    // "a, 1"(real mode chess) to "7,0"(business rule, matrix mode) 
   

    class ChessPosition
    {
        public char column { get; set; }
        public int line { get; set; }

        public ChessPosition(char column, int line)
        {
            this.column = column;
            this.line = line;
        }
        public Position toPosition()
        {
            return new Position(8 - line, column - 'a');
        }
        public override string ToString()
        {
            return "" + column + line;
        }
    }
}
