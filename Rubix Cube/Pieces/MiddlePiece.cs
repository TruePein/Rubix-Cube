namespace Rubix_Cube.Pieces
{
    public class MiddlePiece : Piece
    {

        public MiddlePiece() : base()
        {
            type = Type.Middle;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
