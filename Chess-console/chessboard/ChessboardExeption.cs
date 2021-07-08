using System;
using System.Collections.Generic;
using System.Text;

namespace chessboard
{
    class ChessboardExeption : ApplicationException
    {
        public ChessboardExeption(string msg) : base(msg)
        {

        }
    }
}
