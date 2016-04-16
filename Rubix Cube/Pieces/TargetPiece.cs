namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing the piece the Pieces of the Cube are comparing themselves to.
	/// </summary>
	public class TargetPiece : Piece
    {
		/// <summary>
		/// Default constructor for the Target Piece.
		/// Calls the default base constructor and then sets it's type to Target in order to properly identify it.
		/// </summary>
		public TargetPiece() : base(){
            type = Type.Target;
        }

		/// <summary>
		/// Copy constructor for the Target Piece.
		/// Calls the base copy constructor and then sets it's type to Target in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public TargetPiece(TargetPiece piece) : base(piece)
		{
			type = Type.Target;
		}

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// Since this Piece is the Target Piece, the distance will be 0.
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
