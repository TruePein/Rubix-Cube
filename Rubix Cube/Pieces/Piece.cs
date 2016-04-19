using System;
using System.Collections.Generic;
using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// The base class for all of the pieces of a Rubix Cube.
	/// </summary>
    public abstract class Piece : IPiece
    {

        public Tuple<int,int,int> Coordinates
        {
            get
            {
                return _coordinates;
            }
            set
            {
                _coordinates = value;
            }
        }

		/// <summary>
		/// What kind of piece it is.
		/// </summary>
        public PieceTypes.PieceType type { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        private Tuple<int, int, int> _coordinates;

        /// <summary>
        /// A piece always has 6 sides.
        /// </summary>
        protected const int SIDES = 6;

        /// <summary>
        /// A list of the side of a piece. The order doesn't matter, although it will never change. No two side will share a Color or Position.
        /// </summary>
        public readonly List<Side> sides;
        
		/// <summary>
		/// Constructor for a Piece. Each new Piece is created the same way.
		/// </summary>
        public Piece()
        {
            sides = new List<Side>();
            for(int i = 0; i < SIDES; i++)
            {
                sides.Add(new Side(i));
            }
        }

		/// <summary>
		/// A copy constructor for a piece. Since the Sides may have changed, the Sides are all copied as well.
		/// </summary>
		/// <param name="p"></param>
        public Piece(Piece p)
        {
            sides = new List<Side>();
            for (int i = 0; i < 6; i++)
            {
                sides.Add(new Side(p.sides[i]));
            }
        }

		/// <summary>
		/// Signiature for a method that all child classes have to implement.
		/// </summary>
		/// <param name="piece">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
        public abstract int calculateDistance(TargetPiece piece);

		/// <summary>
		/// Turns a piece on an axis in a direction by 90 degrees.
		/// </summary>
		/// <param name="axis">The axis of the turn.
		/// 0 is the x-axis, leaving the sides on the left and right untouched.
		/// 1 is the y-axis, leaving the sides on the top and bottom untouched.
		/// 2 is the z-axis, leaving the sides on the fromt and back untouched.</param>
		/// <param name="clockwise">Whether or not the ciece will turn clockwise.
		/// true - will turn clockwise
		/// false - won't turn clockwise</param>
		public void turnPiece(Axes.Axis axis, Directions.Direction clockwise)
        {
            switch (axis)
            {
                case Axes.Axis.Z://z
                    changePositions(new SidePositions.Position[]
                    {
                        SidePositions.Position.Top,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Right : SidePositions.Position.Left,
                        SidePositions.Position.Bottom,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Left : SidePositions.Position.Right
                    });
                    break;
                case Axes.Axis.X://x
                    changePositions(new SidePositions.Position[]
                    {
                        SidePositions.Position.Top,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Back : SidePositions.Position.Front,
                        SidePositions.Position.Bottom,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Front : SidePositions.Position.Back
                    });
                    break;
                case Axes.Axis.Y://y
                    changePositions(new SidePositions.Position[]
                    {
                        SidePositions.Position.Front,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Left : SidePositions.Position.Right,
                        SidePositions.Position.Back,
                        clockwise == Directions.Direction.Clockwise ? SidePositions.Position.Right : SidePositions.Position.Left
                    });
                    break;
                default: //do nothing
                    break;
            }
        }

		/// <summary>
		/// Swaps four sides of a piece based on the positions and order of the positions that come in.
		/// </summary>
		/// <param name="positions">An array of positions that need to be swapped with each other.</param>
        private void changePositions(SidePositions.Position[] positions)
        {
            Side sideTo = getSideByPosition(positions[0]);
            SidePositions.Position temp = sideTo.Position;
            for(int i = 0; i < 3; i++)
            {
                Side sideFrom = getSideByPosition(positions[i + 1]);
                sideTo.Position = sideFrom.Position;
                sideTo = sideFrom;
            }
            sideTo.Position = temp;
        }

		/// <summary>
		/// Gets the side for the list of sides based on what color is needed. If there is not exactly one side with the given color, an error is thrown.
		/// </summary>
		/// <param name="color">The color of the side bein searched for.</param>
		/// <returns>Side - The side with the color provided.</returns>
        public Side getSideByColor(Colors.Color color)
        {
			var foundSide = new Side(0);
			var found = false;
            foreach (Side side in sides)
            {
				if (side.Color != color) continue;
				if (found) throw new InvalidOperationException(string.Format("Error: Multiple pieces of color {0} were found.", color));
                foundSide = side;
				found = true;
            }
			if (found)
			{
				return foundSide;
			}
            throw new InvalidOperationException(string.Format("Error: No piece of color {0} was found.", color));
        }

		/// <summary>
		/// Gets the side for the list of sides based on what position is needed. If there is not exactly one side with the given position, an error is thrown.
		/// </summary>
		/// <param name="position">The position of the side bein searched for.</param>
		/// <returns>Side - The side with the position provided.</returns>
		public Side getSideByPosition(SidePositions.Position position)
        {
			var foundSide = new Side(0);
			var found = false;
			foreach (Side side in sides)
            {
				if (side.Position != position) continue;
				if (found) throw new InvalidOperationException(string.Format("Error: Multiple pieces of position {0} were found.", position));
                foundSide = side;
				found = true;
			}
			if (found)
			{
				return foundSide;
			}
			throw new InvalidOperationException(string.Format("Error: No piece of position {0} was found.", position));
        }

        public void MoveToNextCoordinates(Axes.Axis axis, int layer, Directions.Direction clockwise, int SizeOfCube)
        {
            switch (axis)
            {
                case Axes.Axis.X: //x value remains the same
                    {
                        var oldY = _coordinates.Item2;
                        var oldZ = _coordinates.Item3;
                        var newY = clockwise == Directions.Direction.Clockwise ? oldZ : SizeOfCube - (oldZ + 1);
                        var newZ = clockwise == Directions.Direction.Clockwise ? SizeOfCube - (oldY + 1) : oldY;
                        _coordinates = new Tuple<int, int, int>(layer, newY, newZ);
                        break;
                    }
                case Axes.Axis.Y: //y value remains the same
                    {
                        var oldX = _coordinates.Item1;
                        var oldZ = _coordinates.Item3;
                        var newX = clockwise == Directions.Direction.Clockwise ? oldZ : SizeOfCube - (oldZ + 1);
                        var newZ = clockwise == Directions.Direction.Clockwise ? SizeOfCube - (oldX + 1) : oldX;
                        _coordinates = new Tuple<int, int, int>(newX, layer, newZ);
                        break;
                    }
                case Axes.Axis.Z: //z value remains the same
                    {
                        var oldX = _coordinates.Item1;
                        var oldY = _coordinates.Item2;
                        var newX = clockwise == Directions.Direction.Clockwise ? SizeOfCube - (oldY + 1) : oldY;
                        var newY = clockwise == Directions.Direction.Clockwise ? oldX : SizeOfCube - (oldX + 1);
                        _coordinates = new Tuple<int, int, int>(newX, newY, layer);
                        break;
                    }
            }
            turnPiece(axis, clockwise);
        }
    }
}
