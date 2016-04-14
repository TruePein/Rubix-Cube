using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public class InnerPiece : Piece
    {
        private Color color;

        public InnerPiece(string color) : base()
        {
            type = Type.Inner;
            this.color = getColor(color);
        }

        private Color getColor(string color)
        {
            switch (color.ToLower())
            {
                case "white": return Color.White;
                case "red": return Color.Red;
                case "blue": return Color.Blue;
                case "green": return Color.Green;
                case "orange": return Color.Orange;
                default: return Color.Yellow;
            }
        }

        public override int calculateDistance(TargetPiece piece)
        {
            var distance = 0;

            var targetSide = 

            return distance;
        }
    }
}
