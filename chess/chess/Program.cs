using board;
using screen;
using chess;

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
                //board.placePiece(new King(board, Color.White), new Position(0, 0));

                board.placePiece(new Rook(board, Color.White), new Position(4, 2));
                board.placePiece(new Rook(board, Color.White), new Position(6, 3));

                Screen.printBoard(board);

                PositionChess position = new PositionChess('a', 1);
                Console.WriteLine("PositionChess: " + position);
                Console.WriteLine("PositionChess to Position: " + position.toPosition());

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