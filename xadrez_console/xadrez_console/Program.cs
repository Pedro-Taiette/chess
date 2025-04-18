using board;
using System;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Position pos = new Position(3, 4);
            Console.WriteLine(pos);

            Board board = new Board(8, 8);
            Console.WriteLine("Board created with " + board.rows + " rows and " + board.columns + " columns.");
        }
    }
}