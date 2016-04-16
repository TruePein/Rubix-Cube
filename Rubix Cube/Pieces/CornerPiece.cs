﻿using System;

namespace Rubix_Cube.Pieces
{
	/// <summary>
	/// Subclass of Piece representing a piece that appears on the corner of a Cube.
	/// </summary>
	public class CornerPiece : Piece
	{
		/// <summary>
		/// Default constructor for the Corner Piece.
		/// Calls the default base constructor and then sets it's type to Corner in order to properly identify it.
		/// </summary>
		public CornerPiece() : base()
		{
			type = Type.Corner;
		}

		/// <summary>
		/// Copy constructor for the Corner Piece.
		/// Calls the base copy constructor and then sets it's type to Corner in order to properly identify it.
		/// </summary>
		/// <param name="piece">The piece that is being copied.</param>
		public CornerPiece(CornerPiece piece) : base(piece)
		{
			type = Type.Corner;
		}

		/// <summary>
		/// Calculates how many moves the Piece will have to make in order to match the Target Piece.
		/// </summary>
		/// <param name="piece">The piece that this piece is comparing itself to.</param>
		/// <returns>int - How many moves are neccessary to match the target piece.</returns>
		public override int calculateDistance(TargetPiece piece)
        {
            var threeTurns = true;

            int distance = 0;

            for (int i = 0; i < SIDES; i++)
            {
                var side = piece.sides[i].SidePosition;
                var targetColor = piece.sides[i].SideColor;
                var actualSide = side; // top
                for (int j = 0; j < SIDES; j++)
                {
                    if (targetColor != sides[j].SideColor) continue;
                    actualSide = sides[j].SidePosition;
                    break;
                }
                int result = Math.Abs(side - actualSide); //0-5
                if (result == 0)
                {
                    threeTurns = false;
                    continue;
                }
                distance += 1;
                if (result == 3) distance += 1;
            }
            if (distance == 0)
                return distance;//piece is oriented correctly, only hapens if it is in the right place
            if (distance == 4)
                return 1;//piece requires one turn before it is oriented correctly
            if ((distance == 8 && !threeTurns) || distance == 6)
                return 2;//piece requires two turns before it is oriented correctly
            return 3;//piece requires three turns before it is oriented correctly
        }
    }
}
