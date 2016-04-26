using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears on the corner of a Cube.
	/// </summary>
	public class CornerPiece : CornerOrEdgePiece
	{
		/// <summary>
		/// Default constructor for the Corner Piece.
		/// Calls the default base constructor and then sets its type to Corner in order to properly identify it.
		/// </summary>
		public CornerPiece(int x, int y, int z) : base(x, y, z)
		{
			Type = PieceTypes.PieceType.Corner;
		}

		/// <summary>
		/// Copy constructor for the Corner Piece.
		/// Calls the base copy constructor and then sets its type to Corner in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public CornerPiece(IPiece piece) : base(piece)
		{
			Type = PieceTypes.PieceType.Corner;
		}
    }
}
