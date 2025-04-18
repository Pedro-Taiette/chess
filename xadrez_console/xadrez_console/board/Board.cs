namespace board
{
    class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            pieces = new Piece[rows, columns];
        }

        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        }

        public void placePiece(Piece piece, Position position)
        {
            if (piece.position != null)
            {
                pieces[piece.position.row, piece.position.col] = null;
            }
            pieces[position.row, position.col] = piece;
            piece.position = position;
        }
    }
}
