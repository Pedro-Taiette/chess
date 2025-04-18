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
            Position pos = new Position(3, 4);
            Console.WriteLine(pos);

            Board board = new Board(8, 8);
            Console.WriteLine("Board created with " + board.rows + " rows and " + board.columns + " columns.");

            Screen.printBoard(board);

            Console.WriteLine("Placing a piece at position (3, 4).");
            board.placePiece(new Rook(board, Color.Black), new Position(3, 4));
            board.placePiece(new Rook(board, Color.Black), new Position(0, 0));
            board.placePiece(new King(board, Color.White), new Position(2, 3));

            Screen.printBoard(board);
        }
    }
}