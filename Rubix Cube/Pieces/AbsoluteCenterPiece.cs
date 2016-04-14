using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public class AbsoluteCenterPiece :Piece
    {
        public AbsoluteCenterPiece() : base()
        {
            type = Type.AbsoluteCenter;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
