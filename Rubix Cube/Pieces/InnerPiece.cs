using System;
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
        private Colors.Color color;

		/// <summary>
		/// Constructor for the Inner Piece.
		/// Calls the default base constructor.
		/// Sets it's type to Inner in order to properly identify it.
		/// Sets the Color to the given color.
		/// </summary>
		/// <param name="color">The color of the side of the piece that is showing.</param>
		public InnerPiece(Colors.Color color) : base()
        {
            type = PieceTypes.PieceType.Inner;
            this.color = color;
        }

		/// <summary>
		/// Copy constructor for the Inner Piece.
		/// Calls the base copy constructor.
		/// Sets it's type to Inner in order to properly identify it.
		/// Sets the Color to the color of the piven piece.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public InnerPiece(InnerPiece piece) : base(piece)
		{
			type = PieceTypes.PieceType.Inner;
			color = piece.color;
		}

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// Since only one Side is showing, the Positions of the other Sides aren't taken into consideration.
		/// </summary>
		/// <param name="piece">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
		public override int calculateDistance(TargetPiece piece)
        {
            var targetPosition = piece.getSideByColor(color).Position;
            var actualPosition = getSideByColor(color).Position;
            int result = Math.Abs(targetPosition - actualPosition);

            if (result == 0) return result;
			if (result == 3) return 2;
            return 1;
        }
    }
}
