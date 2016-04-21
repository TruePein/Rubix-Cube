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
		/// No other NumOfSides of the Piece will have the same Position.
		/// </summary>
        public SidePositions.Position Position { get; set; }

		
		/// <summary>
		/// The color of the Side.
		/// Once it is set, it cannot be changed.
		/// No other NumOfSides on the Piece will have the same color.
		/// </summary>
		public Colors.Color Color { get; private set; }

	    /// <summary>
	    /// Constructor for the Side.
	    /// Sets both Position and Color to an enumeration representation of the argument passed in.
	    /// </summary>
	    /// <param name="color"></param>
	    /// <param name="position"></param>
	    public Side(Colors.Color color, SidePositions.Position position)
        {
            Position = position;
            Color = color;
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

        public void MoveToNextPosition(Axes.Axis axis, Directions.Direction direction)
        {
            switch (axis)
            {
                case Axes.Axis.X:
                    {
                        Position = GetNextPositionX(direction);
                        break;
                    }
                case Axes.Axis.Y:
                    {
                        Position = GetNextPositionY(direction);
                        break;
                    }
                case Axes.Axis.Z:
                    {
                        Position = GetNextPositionZ(direction);
                        break;
                    }
            }
        }

        public int GetDistanceFrom(SidePositions.Position actualPosition)
        {
            switch (actualPosition)
            {
                case SidePositions.Position.Top:
                    {
                        if (Position == SidePositions.Position.Top) return 0;
                        if (Position == SidePositions.Position.Bottom) return 2;
                        return 1;
                    }
                case SidePositions.Position.Front:
                    {
                        if (Position == SidePositions.Position.Front) return 0;
                        if (Position == SidePositions.Position.Back) return 2;
                        return 1;
                    }
                case SidePositions.Position.Right:
                    {
                        if (Position == SidePositions.Position.Right) return 0;
                        if (Position == SidePositions.Position.Left) return 2;
                        return 1;
                    }
                case SidePositions.Position.Bottom:
                    {
                        if (Position == SidePositions.Position.Bottom) return 0;
                        if (Position == SidePositions.Position.Top) return 2;
                        return 1;
                    }
                case SidePositions.Position.Back:
                    {
                        if (Position == SidePositions.Position.Back) return 0;
                        if (Position == SidePositions.Position.Front) return 2;
                        return 1;
                    }
                case SidePositions.Position.Left:
                    {
                        if (Position == SidePositions.Position.Left) return 0;
                        if (Position == SidePositions.Position.Right) return 2;
                        return 1;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        private SidePositions.Position GetNextPositionX(Directions.Direction direction)
        {
            if (Position == SidePositions.Position.Top)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Back : SidePositions.Position.Front;
            }
            if (Position == SidePositions.Position.Back)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Bottom : SidePositions.Position.Top;
            }
            if (Position == SidePositions.Position.Bottom)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Front : SidePositions.Position.Back;
            }
            if (Position == SidePositions.Position.Front)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Top : SidePositions.Position.Bottom;
            }
            return Position;
        }

        private SidePositions.Position GetNextPositionY(Directions.Direction direction)
        {
            if (Position == SidePositions.Position.Front)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Left : SidePositions.Position.Right;
            }
            if (Position == SidePositions.Position.Left)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Back : SidePositions.Position.Front;
            }
            if (Position == SidePositions.Position.Back)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Right : SidePositions.Position.Left;
            }
            if (Position == SidePositions.Position.Right)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Front : SidePositions.Position.Back;
            }
            return Position;
        }

        private SidePositions.Position GetNextPositionZ(Directions.Direction direction)
        {
            if (Position == SidePositions.Position.Top)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Right : SidePositions.Position.Left;
            }
            if (Position == SidePositions.Position.Right)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Bottom : SidePositions.Position.Top;
            }
            if (Position == SidePositions.Position.Bottom)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Left : SidePositions.Position.Right;
            }
            if (Position == SidePositions.Position.Left)
            {
                return direction == Directions.Direction.Clockwise ? SidePositions.Position.Top : SidePositions.Position.Bottom;
            }
            return Position;
        }
    }
}
