namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears in the Middle of a Cube.
	/// Only one Color is ever showing.
	/// </summary>
	public class MiddlePiece : Piece
    {
		/// <summary>
		/// Constructor for the Middle Piece.
		/// Calls the default base constructor.
		/// Sets it's type to Middle in order to properly identify it.
		/// </summary>
		public MiddlePiece() : base()
        {
            type = Type.Middle;
        }

		/// <summary>
		/// Copy constructor for the Middle Piece.
		/// Calls the base copy constructor.
		/// Sets it's type to Middle in order to properly identify it.
		/// </summary>
		/// <param name="piece"></param>
		public MiddlePiece(MiddlePiece piece) : base()
		{
			type = Type.Middle;
		}

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// Since the Piece is in the Middle, its showing side is always lined up with the Target Piece.
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
