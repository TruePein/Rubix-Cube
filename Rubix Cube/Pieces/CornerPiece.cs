using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int distance = 0;
            return distance;
        }
    }
}
