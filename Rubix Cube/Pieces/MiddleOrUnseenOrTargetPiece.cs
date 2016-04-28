namespace Rubix_Cube.Pieces
{
    public class MiddleOrUnseenOrTargetPiece : Piece
    {
        public MiddleOrUnseenOrTargetPiece(int x, int y, int z):base(x, y, z) { }

        public MiddleOrUnseenOrTargetPiece(IPiece p) : base(p) { }
        
        public override int CalculateDistance(TargetPiece target)
        {
            return 0;
        }
    }
}
