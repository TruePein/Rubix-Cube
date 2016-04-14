using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public class TargetPiece : Piece
    {
        public TargetPiece() : base(){
            type = Type.Target;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
