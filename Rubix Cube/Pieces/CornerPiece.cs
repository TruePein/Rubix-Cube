using System;

namespace Rubix_Cube.Pieces
{
    public class CornerPiece:Piece
    {
        public CornerPiece():base()
        {
            type = Type.Corner;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            var threeTurns = true;

            int distance = 0;

            for (int i = 0; i < SIDES; i++)
            {
                var side = piece.colors[i].SidePosition;
                var targetColor = piece.colors[i].SideColor;
                var actualSide = side; // top
                for (int j = 0; j < SIDES; j++)
                {
                    if (targetColor != colors[j].SideColor) continue;
                    actualSide = colors[j].SidePosition;
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
