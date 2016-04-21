using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing the pieces that can't be seen.
	/// </summary>
	public class UnseenPiece : MiddleOrUnseenOrTargetPiece
    {
		/// <summary>
		/// Default constructor for the Unseen Piece.
		/// Calls the default base constructor and then sets it's type to Unseen in order to properly identify it.
		/// </summary>
		public UnseenPiece(int x, int y, int z) : base(x, y, z)
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
    }
}
