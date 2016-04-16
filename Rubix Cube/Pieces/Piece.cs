using System.Collections.Generic;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// The base class for all of the pieces of a Rubix Cube.
	/// </summary>
    public abstract class Piece
    {
		/// <summary>
		/// What kind of piece it is.
		/// </summary>
        public Type type { get; protected set; }

		/// <summary>
		/// A piece always has 6 sides.
		/// </summary>
        protected const int SIDES = 6;

		/// <summary>
		/// The different types of pieces.
		///		Unseen appear in Cubes of SIZE > 2.
		///		Middle appear in Cubes with an odd size.
		///		Inner appear in Cubes of SIZE > 3.
		///		Side appear in Cubes of SIZE > 2.
		///		Corner appear in every Cube.
		///		Target appear with every Cube.
		/// </summary>
        public enum Type
        {
            Unseen,
            Middle,
            Inner,
            Edge,
            Corner,
            Target
        }

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
		public void turnPiece(int axis, bool clockwise)
        {
            switch (axis)
            {
                case 2://z
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Top,
                        clockwise?Side.Position.Right:Side.Position.Left,
                        Side.Position.Bottom,
                        clockwise?Side.Position.Left:Side.Position.Right
                    });
                    break;
                case 0://x
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Top,
                        clockwise?Side.Position.Back:Side.Position.Front,
                        Side.Position.Bottom,
                        clockwise?Side.Position.Front:Side.Position.Back
                    });
                    break;
                case 1://y
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Front,
                        clockwise?Side.Position.Left:Side.Position.Right,
                        Side.Position.Back,
                        clockwise?Side.Position.Right:Side.Position.Left
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
        private void changePositions(Side.Position[] positions)
        {
            Side sideTo = getSideByPosition(positions[0]);
            Side.Position temp = sideTo.SidePosition;
            for(int i = 0; i < 3; i++)
            {
                Side sideFrom = getSideByPosition(positions[i + 1]);
                sideTo.SidePosition = sideFrom.SidePosition;
                sideTo = sideFrom;
            }
            sideTo.SidePosition = temp;
        }

		/// <summary>
		/// Gets the side for the list of sides based on what color is needed. If there is not exactly one side with the given color, an error is thrown.
		/// </summary>
		/// <param name="color">The color of the side bein searched for.</param>
		/// <returns>Side - The side with the color provided.</returns>
        public Side getSideByColor(Side.Color color)
        {
			var foundSide = new Side(0);
			var found = false;
            foreach (Side side in sides)
            {
				if (side.SideColor != color) continue;
				if (found) throw new System.Exception();
				foundSide = side;
				found = true;
            }
			if (found)
			{
				return foundSide;
			}
            throw new System.Exception();
        }

		/// <summary>
		/// Gets the side for the list of sides based on what position is needed. If there is not exactly one side with the given position, an error is thrown.
		/// </summary>
		/// <param name="position">The position of the side bein searched for.</param>
		/// <returns>Side - The side with the position provided.</returns>
		public Side getSideByPosition(Side.Position position)
        {
			var foundSide = new Side(0);
			var found = false;
			foreach (Side side in sides)
            {
				if (side.SidePosition != position) continue;
				if (found) throw new System.Exception();
				foundSide = side;
				found = true;
			}
			if (found)
			{
				return foundSide;
			}
			throw new System.Exception();
        }
    }
}
