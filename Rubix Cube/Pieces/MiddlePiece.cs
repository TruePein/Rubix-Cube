using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears in the Middle of a Cube.
	/// Only one Color is ever showing.
	/// </summary>
	public class MiddlePiece : MiddleOrUnseenOrTargetPiece
    {
	    private readonly MiddlePiece _piece;

        /// <summary>
        /// Constructor for the Middle Piece.
        /// Calls the default base constructor.
        /// Sets its type to Middle in order to properly identify it.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public MiddlePiece(int x, int y, int z) : base(x, y, z)
        {
            Type = PieceTypes.PieceType.Middle;
        }

		/// <summary>
		/// Copy constructor for the Middle Piece.
		/// Calls the base copy constructor.
		/// Sets its type to Middle in order to properly identify it.
		/// </summary>
		/// <param name="piece"></param>
		public MiddlePiece(MiddlePiece piece) : base(piece)
		{
		    _piece = piece;
		    Type = PieceTypes.PieceType.Middle;
		}
    }
}
