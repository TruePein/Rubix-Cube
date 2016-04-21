using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears in the Middle of a Cube.
	/// Only one Color is ever showing.
	/// </summary>
	public class MiddlePiece : MiddleOrUnseenOrTargetPiece
    {
		/// <summary>
		/// Constructor for the Middle Piece.
		/// Calls the default base constructor.
		/// Sets it's type to Middle in order to properly identify it.
		/// </summary>
		public MiddlePiece(int x, int y, int z) : base(x, y, z)
        {
            type = PieceTypes.PieceType.Middle;
        }

		/// <summary>
		/// Copy constructor for the Middle Piece.
		/// Calls the base copy constructor.
		/// Sets it's type to Middle in order to properly identify it.
		/// </summary>
		/// <param name="piece"></param>
		public MiddlePiece(MiddlePiece piece) : base(piece)
		{
			type = PieceTypes.PieceType.Middle;
		}
    }
}
