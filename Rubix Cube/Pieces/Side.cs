namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Class representing a Side of a Piece.
	/// </summary>
    public class Side
    {
		/// <summary>
		/// The possible Positions that a side can be on a Piece.
		///		Top is on the top of a Piece.
		///		Front is on the front of a Piece.
		///		Right is on the right of a Piece.
		///		Bottom is on the bottom of a Piece.
		///		Back is on the back of a Piece.
		///		Left is on the left of a Piece.
		/// </summary>
		public enum Position
        {
            Top, Front, Right, Bottom, Back, Left
        }

		/// <summary>
		/// The current Position of the Side.
		/// No other Sides of the Piece will have the same Position.
		/// </summary>
        public Position SidePosition { get; set; }

		/// <summary>
		/// The possible Colors the a Side can be on a Piece.
		/// </summary>
        public enum Color
        {
            White, Red, Blue, Yellow, Orange, Green
        }
		
		/// <summary>
		/// The color of the Side.
		/// Once it is set, it cannot be changed.
		/// No other Sides on the Piece will have the same color.
		/// </summary>
		public Color SideColor { get; private set; }

		/// <summary>
		/// Constructor for the Side.
		/// Sets both Position and Color to an enumeration representation of the argument passed in.
		/// </summary>
		/// <param name="i">An integer that matches a Position and Side together at the same time.</param>
		public Side(int i)
        {
            SidePosition = (Position)i;
            SideColor = (Color)i;
        }

		/// <summary>
		/// Copy constructor for the Side.
		/// Sets the Position and color the the corresponding values of the Side that is being copied.
		/// </summary>
		/// <param name="side">The Side that is being copied.</param>
		public Side(Side side)
        {
            SidePosition = side.SidePosition;
            SideColor = side.SideColor;
        }
    }
}
