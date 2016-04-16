namespace Rubix_Cube.Pieces
{
    public static class PieceFactory
    {
        public static Piece GetPiece(int x, int y, int z, int size, Piece p = null)
        {
            Piece piece = new UnseenPiece();

            return piece;
        }
    }
}
