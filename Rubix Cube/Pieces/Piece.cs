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
        /// <summary>
        /// 
        /// </summary>
        public Tuple<int,int,int> Coordinates { get; set; }

	    /// <summary>
		/// What kind of piece it is.
		/// </summary>
        public PieceTypes.PieceType Type { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
	    public List<Side> Sides { get; }

	    /// <summary>
        /// Constructor for a Piece. Each new Piece is created the same way.
        /// </summary>
        protected Piece(int x, int y, int z)
	    {
		    Sides = new List<Side>
		    {
		        new Side(Colors.Color.White, SidePositions.Position.Top),
		        new Side(Colors.Color.Red, SidePositions.Position.Front),
		        new Side(Colors.Color.Blue, SidePositions.Position.Right),
		        new Side(Colors.Color.Yellow, SidePositions.Position.Bottom),
		        new Side(Colors.Color.Orange, SidePositions.Position.Back),
		        new Side(Colors.Color.Green, SidePositions.Position.Left)
		    };
		    Coordinates = new Tuple<int, int, int>(x, y, z);
        }

		/// <summary>
		/// A copy constructor for a piece. Since the NumOfSides may have changed,
		/// the NumOfSides are all copied as well.
		/// </summary>
		/// <param name="p"></param>
		protected Piece(IPiece p)
		{
            Sides = new List<Side>();
		    foreach (var side in p.Sides)
		    {
		        Sides.Add(new Side(side));
		    }
            Coordinates = new Tuple<int, int, int>(p.Coordinates.Item1, p.Coordinates.Item2, p.Coordinates.Item3);
        }

		/// <summary>
		/// Signiature for a method that all child classes have to implement.
		/// </summary>
		/// <param name="target">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
        public abstract int CalculateDistance(TargetPiece target);

		/// <summary>
		/// Turns a piece on an axis in a direction by 90 degrees.
		/// </summary>
		/// <param name="axis">The axis of the turn.</param>
		/// <param name="direction">Whether or not the ciece will turn clockwise.</param>
		public void TurnPiece(Axes.Axis axis, Directions.Direction direction)
        {
            foreach (var side in Sides)
            {
                side.MoveToNextPosition(axis, direction);
            }
        }

		/// <summary>
		/// Gets the side from the list of sides based on what color is needed. If there is not exactly one side with the given color, an error is thrown.
		/// </summary>
		/// <param name="color">The color of the side bein searched for.</param>
		/// <returns>Side - The side with the color provided.</returns>
        public Side GetSideByColor(Colors.Color color)
        {
			var foundSide = new Side(color, SidePositions.Position.Top);
			var found = 0;
            foreach (var side in Sides)
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
		public Side GetSideByPosition(SidePositions.Position position)
        {
            var foundSide = new Side(Colors.Color.White, position);
            var found = 0;
			foreach (var side in Sides)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="direction"></param>
        /// <param name="sizeOfCube"></param>
        public void MoveToNextCoordinates(Axes.Axis axis, Directions.Direction direction, int sizeOfCube)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (axis)
            {
                case Axes.Axis.X: //x value remains the same
                    {
                        MoveToNextCoordinatesOnXAxis(direction, sizeOfCube);
                        break;
                    }
                case Axes.Axis.Y: //y value remains the same
                    {
                        MoveToNextCoordinatesOnYAxis(direction, sizeOfCube);
                        break;
                    }
                case Axes.Axis.Z: //z value remains the same
                    {
                        MoveToNextCoordinatesOnZAxis(direction, sizeOfCube);
                        break;
                    }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="sizeOfCube"></param>
	    private void MoveToNextCoordinatesOnXAxis(Directions.Direction direction, int sizeOfCube)
	    {
	        var oldY = Coordinates.Item2;
	        var oldZ = Coordinates.Item3;
	        var newY = direction == Directions.Direction.Clockwise ? sizeOfCube - (oldZ + 1) : oldZ;
	        var newZ = direction == Directions.Direction.Clockwise ? oldY : sizeOfCube - (oldY + 1);
	        Coordinates = new Tuple<int, int, int>(Coordinates.Item1, newY, newZ);
	    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="sizeOfCube"></param>
	    private void MoveToNextCoordinatesOnYAxis(Directions.Direction direction, int sizeOfCube)
	    {
	        var oldX = Coordinates.Item1;
	        var oldZ = Coordinates.Item3;
	        var newX = direction == Directions.Direction.Clockwise ? oldZ : sizeOfCube - (oldZ + 1);
	        var newZ = direction == Directions.Direction.Clockwise ? sizeOfCube - (oldX + 1) : oldX;
	        Coordinates = new Tuple<int, int, int>(newX, Coordinates.Item2, newZ);
	    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="sizeOfCube"></param>
	    private void MoveToNextCoordinatesOnZAxis(Directions.Direction direction, int sizeOfCube)
	    {
	        var oldX = Coordinates.Item1;
	        var oldY = Coordinates.Item2;
            var newX = direction == Directions.Direction.Clockwise ? sizeOfCube - (oldY + 1) : oldY;
	        var newY = direction == Directions.Direction.Clockwise ? oldX : sizeOfCube - (oldX + 1);
	        Coordinates = new Tuple<int, int, int>(newX, newY, Coordinates.Item3);
	    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="direction"></param>
        /// <param name="sizeOfCube"></param>
	    public void Move(Axes.Axis axis, Directions.Direction direction, int sizeOfCube)
	    {
	        MoveToNextCoordinates(axis, direction, sizeOfCube);
	        TurnPiece(axis, direction);
	    }
    }
}
