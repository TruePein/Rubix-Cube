using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Class representing a Side of a Piece.
	/// </summary>
    public class Side
    {
		/// <summary>
		/// The current Position of the Side.
		/// No other Sides of the Piece will have the same Position.
		/// </summary>
        public SidePositions.Position Position { get; set; }

		
		/// <summary>
		/// The color of the Side.
		/// Once it is set, it cannot be changed.
		/// No other Sides on the Piece will have the same color.
		/// </summary>
		public Colors.Color Color { get; private set; }

		/// <summary>
		/// Constructor for the Side.
		/// Sets both Position and Color to an enumeration representation of the argument passed in.
		/// </summary>
		/// <param name="i">An integer that matches a Position and Side together at the same time.</param>
		public Side(int i)
        {
            Position = (SidePositions.Position)i;
            Color = (Colors.Color)i;
        }

		/// <summary>
		/// Copy constructor for the Side.
		/// Sets the Position and color the the corresponding values of the Side that is being copied.
		/// </summary>
		/// <param name="side">The Side that is being copied.</param>
		public Side(Side side)
        {
            Position = side.Position;
            Color = side.Color;
        }
    }
}
