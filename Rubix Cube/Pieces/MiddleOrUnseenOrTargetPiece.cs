namespace Rubix_Cube.Pieces
{
    public class MiddleOrUnseenOrTargetPiece : Piece
    {
        public MiddleOrUnseenOrTargetPiece(int x, int y, int z):base(x, y, z) { }

        public MiddleOrUnseenOrTargetPiece(Piece p) : base(p) { }
        
        /// <summary>
        /// Calculates how many moves the Piece will have to make in order to match the Target Piece.
        /// Since this Piece is never seen, it doesn't matter how many moves away it is from the Target Piece, so the distance will be 0.
        /// </summary>
        /// <param name="target">The piece that this piece is comparing itself to.</param>
        /// <returns>int - How many moves are neccessary to match the target piece.
        /// Always 0.</returns>
        public override int CalculateDistance(TargetPiece target)
        {
            return 0;
        }
    }
}
