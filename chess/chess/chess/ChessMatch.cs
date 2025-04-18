using board;

namespace chess
{
    class ChessMatch
    {
        public Board board { get; private set; }
        private int turn;
        private Color currentPlayer;
        public bool finished { get; private set; }

        public ChessMatch()
        {
            board = new Board(8, 8);
            turn = 1;
            currentPlayer = Color.White;
            finished = false;
            placeInitialPieces();
        }

        public void executeMove(Position origin, Position target)
        {
            Piece piece = board.removePiece(origin);
            piece.increaseMoveCount();
            Piece capturedPiece = board.removePiece(target);
            board.placePiece(piece, target);
        }

        private void placeInitialPieces()
        {
            board.placePiece(new Rook(board, Color.White), new ChessPosition('c', 1).toPosition());
            board.placePiece(new Rook(board, Color.White), new ChessPosition('c', 2).toPosition());
            board.placePiece(new Rook(board, Color.White), new ChessPosition('d', 2).toPosition());
            board.placePiece(new Rook(board, Color.White), new ChessPosition('e', 2).toPosition());
            board.placePiece(new Rook(board, Color.White), new ChessPosition('e', 1).toPosition());
            board.placePiece(new Rook(board, Color.White), new ChessPosition('d', 1).toPosition());

            board.placePiece(new King(board, Color.Black), new ChessPosition('e', 3).toPosition());
            board.placePiece(new King(board, Color.Black), new ChessPosition('e', 7).toPosition());
            board.placePiece(new King(board, Color.Black), new ChessPosition('d', 7).toPosition());
            board.placePiece(new King(board, Color.Black), new ChessPosition('c', 7).toPosition());
            board.placePiece(new King(board, Color.Black), new ChessPosition('c', 3).toPosition());
        }
    }
}
