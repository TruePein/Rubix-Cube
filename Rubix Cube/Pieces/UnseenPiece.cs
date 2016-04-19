using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing the pieces that can't be seen.
	/// </summary>
	public class UnseenPiece : Piece
    {
		/// <summary>
		/// Default constructor for the Unseen Piece.
		/// Calls the default base constructor and then sets it's type to Unseen in order to properly identify it.
		/// </summary>
		public UnseenPiece() : base()
        {
            type = PieceTypes.PieceType.Unseen;
        }

		/// <summary>
		/// Copy constructor for the Unseen Piece.
		/// Calls the base copy constructor and then sets it's type to Unseen in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public UnseenPiece(UnseenPiece piece) : base(piece)
        {
            type = PieceTypes.PieceType.Unseen;
        }

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// Since this Piece is never seen, it doesn't matter how many moves away it is from the Target Piece, so the distance will be 0.
		/// </summary>
		/// <param name="piece">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.
		/// Always 0.</returns>
		public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
