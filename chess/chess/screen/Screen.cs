using board;
using chess;

namespace screen
{
    class Screen
    {
        public static void printBoard(Board board)
        {   

            Console.WriteLine();
            Console.WriteLine("  ___________________");
            for (int i = 0; i < board.rows; i++)
            {
                Console.Write(8 - i + " | "); // Números das linhas
                for (int j = 0; j < board.columns; j++)
                {
                    var piece = board.piece(i, j);

                    if (piece == null)
                        Console.Write("- "); // Espaço vazio
                    else
                    {
                        printPiece(board.piece(i, j)); // piece 
                        Console.Write(" ");
                    }       
                }
                Console.Write("|");
                Console.WriteLine();
            }
                                 
            Console.WriteLine("  -------------------");
            Console.WriteLine("    A B C D E F G H\n");
        }

        public static void printPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");

            return new ChessPosition(column, row);
        }
    }
}
