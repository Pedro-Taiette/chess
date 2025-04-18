using board;
using chess_console.screen;
using chess;
using System;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                Console.WriteLine("Placing a piece at position (3, 4).");
                board.placePiece(new Rook(board, Color.Black), new Position(3, 4));
                board.placePiece(new Rook(board, Color.Black), new Position(0, 0));
                board.placePiece(new King(board, Color.White), new Position(0, 0));

                Screen.printBoard(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
        }
    }
}