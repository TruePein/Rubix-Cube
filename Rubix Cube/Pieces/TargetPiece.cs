namespace Rubix_Cube.Pieces
{
    public class TargetPiece : Piece
    {
        public TargetPiece() : base(){
            type = Type.Target;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
