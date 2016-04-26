using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears around the Middle Piece but not on the edge of a Cube.
	/// Only one Color is ever showing.
	/// </summary>
	public class InnerPiece : Piece
    {
	    /// <summary>
		/// The Color that this Piece is showing. This value will never change.
		/// </summary>
        public Colors.Color Color { get; }

	    /// <summary>
	    /// Constructor for the Inner Piece.
	    /// Calls the default base constructor.
	    /// Sets its type to Inner in order to properly identify it.
	    /// Sets the Color to the given color.
	    /// </summary>
	    /// <param name="color">The color of the side of the piece that is showing.</param>
	    /// <param name="x"></param>
	    /// <param name="y"></param>
	    /// <param name="z"></param>
	    public InnerPiece(int x, int y, int z, Colors.Color color) : base(x, y, z)
        {
            Type = PieceTypes.PieceType.Inner;
            Color = color;
        }

		/// <summary>
		/// Copy constructor for the Inner Piece.
		/// Calls the base copy constructor.
		/// Sets its type to Inner in order to properly identify it.
		/// Sets the Color to the color of the piven piece.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public InnerPiece(InnerPiece piece) : base(piece)
		{
		    Type = PieceTypes.PieceType.Inner;
			Color = piece.Color;
		}

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// Since only one Side is showing, the Positions of the other NumOfSides aren't taken into consideration.
		/// </summary>
		/// <param name="target">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
		public override int CalculateDistance(TargetPiece target)
        {
            var targetSide = target.GetSideByColor(Color);
            var actualPosition = GetSideByColor(Color).Position;
            return targetSide.GetDistanceFrom(actualPosition);
        }
    }
}
