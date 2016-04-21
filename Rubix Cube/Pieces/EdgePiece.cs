using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears on the Edge of a Cube.
	/// </summary>
	public class EdgePiece : CornerOrEdgePiece
    {
		/// <summary>
		/// Default constructor for the Side Piece.
		/// Calls the default base constructor and then sets it's type to Edge in order to properly identify it.
		/// </summary>
		public EdgePiece(int x, int y, int z) : base(x, y, z)
        {
            Type = PieceTypes.PieceType.Edge;
        }

		/// <summary>
		/// Copy constructor for the Corner Piece.
		/// Calls the base copy constructor and then sets it's type to Corner in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public EdgePiece(EdgePiece piece) : base(piece)
		{
			Type = PieceTypes.PieceType.Edge;
		}
    }
}
