using System;
using chessboard;
using chess;

namespace Chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();

                while (!chessGame.finished)
                {
                    Console.Clear();
                    Screen.printChessBoard(chessGame.chessBoard);

                    Console.WriteLine();
                    Console.Write("Enter to origin position :");
                    Position origin = Screen.readChessPosition().toPosition();

                    Console.Write("Enter to destiny position :");
                    Position destiny = Screen.readChessPosition().toPosition();

                    chessGame.movement(origin, destiny);


                    Screen.printChessBoard(chessGame.chessBoard);


                }


                


            }
            catch (ChessboardExeption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
