using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing the piece the Pieces of the Cube are comparing themselves to.
	/// </summary>
	public class TargetPiece : MiddleOrUnseenOrTargetPiece
    {
		/// <summary>
		/// Default constructor for the Target Piece.
		/// Calls the default base constructor and then sets its type to Target in order to properly identify it.
		/// </summary>
		public TargetPiece() : base(0, 0, 0){
            Type = PieceTypes.PieceType.Target;
        }

		/// <summary>
		/// Copy constructor for the Target Piece.
		/// Calls the base copy constructor and then sets its type to Target in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public TargetPiece(IPiece piece) : base(piece)
		{
			Type = PieceTypes.PieceType.Target;
		}
    }
}
