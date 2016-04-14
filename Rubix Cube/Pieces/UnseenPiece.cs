using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public class UnseenPiece : Piece
    {
        public UnseenPiece() : base()
        {
            type = Type.Unseen;
        }

        public UnseenPiece(Piece p) : base(p)
        {
            type = Type.Unseen;
        }

        public override int calculateDistance(TargetPiece piece)
        {
            return 0;
        }
    }
}
