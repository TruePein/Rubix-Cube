using System;

namespace Rubix_Cube.Pieces
{
    public class InnerPiece : Piece
    {
        private Side.Color color;

        public InnerPiece(Side.Color color) : base()
        {
            type = Type.Inner;
            this.color = color;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            var targetPosition = piece.getSideByColor(color).SidePosition;
            var actualPosition = getSideByColor(color).SidePosition;
            int result = Math.Abs(targetPosition - actualPosition);

            if (result == 0 || result == 2) return result;
            return 1;
        }
    }
}
