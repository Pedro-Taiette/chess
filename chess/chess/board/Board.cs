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

        public Piece piece(Position position)
        {
            return pieces[position.row, position.col];
        }

        public bool existPiece(Position position)
        {
            validatePosition(position); 
            return piece(position) != null;
        }

        public bool isValidPosition(Position position)
        {
            if (position.row < 0 || position.row >= rows || position.col < 0 || position.col >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position position)
        {
            if (!isValidPosition(position))
            {
                throw new BoardException("Invalid position: " + position);
            }
        }

        public void placePiece(Piece piece, Position position)
        {
            if (existPiece(position))
            {
                throw new BoardException("There is already a piece at position: " + position);
            }

            pieces[position.row, position.col] = piece;
            piece.position = position;
        }

        public Piece removePiece(Position position)
        {
            if (piece(position) == null)
            {
                return null;
            }

            Piece temp = piece(position);
            temp.position = null;
            pieces[position.row, position.col] = null;
            return temp;
        }
    }
}
