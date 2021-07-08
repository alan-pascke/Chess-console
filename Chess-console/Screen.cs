
using chessboard;

namespace Chess_console
{
    class Screen
    {
        public static void printChessBoard( ChessBoard chessBoard)
        {
            for (int i = 0; i < chessBoard.lines; i++)
            {
                for (int j = 0; j < chessBoard.columns; j++)
                {
                    if (chessBoard.piece(i, j) == null)
                    {
                        System.Console.Write(" -  | ");
                    }
                    else 
                    { 
                    System.Console.Write(chessBoard.piece(i, j) + " | ");
                    }
                    
                }
                
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }
    }
}
