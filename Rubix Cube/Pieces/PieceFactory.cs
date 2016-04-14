using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public static class PieceFactory
    {
        public static Piece GetPiece()
        {
            Piece piece = new UnseenPiece();

            return piece;
        }

        public static Piece GetPiece(Piece p)
        {
            Piece piece = new UnseenPiece(p);

            return piece;
        }
    }
}
