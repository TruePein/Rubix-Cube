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
        public Piece(int x, int y, int z)
        {
            sides = new List<Side>();
            sides.Add(new Side(Colors.Color.White, SidePositions.Position.Top));
            sides.Add(new Side(Colors.Color.Red, SidePositions.Position.Front));
            sides.Add(new Side(Colors.Color.Blue, SidePositions.Position.Right));
            sides.Add(new Side(Colors.Color.Yellow, SidePositions.Position.Bottom));
            sides.Add(new Side(Colors.Color.Orange, SidePositions.Position.Back));
            sides.Add(new Side(Colors.Color.Green, SidePositions.Position.Left));
            _coordinates = new Tuple<int, int, int>(x, y, z);
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
            _coordinates = new Tuple<int, int, int>(p._coordinates.Item1, p._coordinates.Item2, p._coordinates.Item3);
        }

		/// <summary>
		/// Signiature for a method that all child classes have to implement.
		/// </summary>
		/// <param name="piece">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
        public abstract int calculateDistance(TargetPiece target);

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
		public void turnPiece(Axes.Axis axis, Directions.Direction direction)
        {
            foreach (var side in sides)
            {
                side.MoveToNextPosition(axis, direction);
            }
        }

		/// <summary>
		/// Gets the side from the list of sides based on what color is needed. If there is not exactly one side with the given color, an error is thrown.
		/// </summary>
		/// <param name="color">The color of the side bein searched for.</param>
		/// <returns>Side - The side with the color provided.</returns>
        public Side getSideByColor(Colors.Color color)
        {
			var foundSide = new Side(color, SidePositions.Position.Top);
			var found = 0;
            foreach (Side side in sides)
            {
				if (side.Color != color) continue;
                foundSide = side;
				found++;
            }
			if (found == 1)
			{
				return foundSide;
			}
            throw new InvalidOperationException(string.Format("Error: {0} pieces of color {1} were found.", found, color));
        }

		/// <summary>
		/// Gets the side from the list of sides based on what position is needed. If there is not exactly one side with the given position, an error is thrown.
		/// </summary>
		/// <param name="position">The position of the side bein searched for.</param>
		/// <returns>Side - The side with the position provided.</returns>
		public Side getSideByPosition(SidePositions.Position position)
        {
            var foundSide = new Side(Colors.Color.White, position);
            var found = 0;
			foreach (Side side in sides)
            {
				if (side.Position != position) continue;
                foundSide = side;
				found++;
			}
			if (found == 1)
			{
				return foundSide;
			}
			throw new InvalidOperationException(string.Format("Error: {0} pieces of position {1} were found.", found, position));
        }

        public void MoveToNextCoordinates(Axes.Axis axis, Directions.Direction direction, int SizeOfCube)
        {
            switch (axis)
            {
                case Axes.Axis.X: //x value remains the same
                    {
                        moveToNextCoordinatesOnXAxis(direction, SizeOfCube);
                        break;
                    }
                case Axes.Axis.Y: //y value remains the same
                    {
                        moveToNextCoordinatesOnYAxis(direction, SizeOfCube);
                        break;
                    }
                case Axes.Axis.Z: //z value remains the same
                    {
                        moveToNextCoordinatesOnZAxis(direction, SizeOfCube);
                        break;
                    }
            }
        }

        private void moveToNextCoordinatesOnXAxis(Directions.Direction direction, int SizeOfCube)
        {
            var oldY = _coordinates.Item2;
            var oldZ = _coordinates.Item3;
            var newY = direction == Directions.Direction.Clockwise ? oldZ : SizeOfCube - (oldZ + 1);
            var newZ = direction == Directions.Direction.Clockwise ? SizeOfCube - (oldY + 1) : oldY;
            _coordinates = new Tuple<int, int, int>(_coordinates.Item1, newY, newZ);
        }

        private void moveToNextCoordinatesOnYAxis(Directions.Direction direction, int SizeOfCube)
        {
            var oldX = _coordinates.Item1;
            var oldZ = _coordinates.Item3;
            var newX = direction == Directions.Direction.Clockwise ? oldZ : SizeOfCube - (oldZ + 1);
            var newZ = direction == Directions.Direction.Clockwise ? SizeOfCube - (oldX + 1) : oldX;
            _coordinates = new Tuple<int, int, int>(newX, _coordinates.Item2, newZ);
        }

        private void moveToNextCoordinatesOnZAxis(Directions.Direction direction, int SizeOfCube)
        {
            var oldX = _coordinates.Item1;
            var oldY = _coordinates.Item2;
            var newX = direction == Directions.Direction.Clockwise ? SizeOfCube - (oldY + 1) : oldY;
            var newY = direction == Directions.Direction.Clockwise ? oldX : SizeOfCube - (oldX + 1);
            _coordinates = new Tuple<int, int, int>(newX, newY, _coordinates.Item3);
        }

        public void Move(Axes.Axis axis, Directions.Direction direction, int sizeOfCube)
        {
            MoveToNextCoordinates(axis, direction, sizeOfCube);
            turnPiece(axis, direction);
        }
    }
}
