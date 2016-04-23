using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class CubeFullEqualityComparer:IEqualityComparer<Cube>
    {
        public bool Equals(Cube x, Cube y)
        {
            if (x.Score != y.Score) return false;
            if (x.MovesMade != y.MovesMade) return false;
            var pieceComparer = new PieceEqualityComparer();
            for (var i = 0; i < Math.Pow(x.Size, 3); i++)
            {
                if (!pieceComparer.Equals(x.Pieces[i], y.Pieces[i])) return false;
            }
            return true;
        }

        public int GetHashCode(Cube obj)
        {
            return obj.GetHashCode();
        }
    }
}
