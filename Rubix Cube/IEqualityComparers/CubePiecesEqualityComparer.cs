using System;
using System.Collections.Generic;

namespace Rubix_Cube.IEqualityComparers
{
    public class CubePiecesEqualityComparer:IEqualityComparer<Cube>
    {
        public bool Equals(Cube x, Cube y)
        {
            if (x == y)
                throw new ArgumentException($"The two objects both point to the same {x.GetType()} object.");
            var pieceComparer = new PieceEqualityComparer();
            for (var i = 0; i < x.Size; i++)
            {
                for (int j = 0; j < x.Size; j++)
                {
                    for (int k = 0; k < x.Size; k++)
                    {
                        if (!pieceComparer.Equals(x.GetPieceByCoordinates(i, j, k), y.GetPieceByCoordinates(i, j, k)))
                            return false;
                    }
                }
                if (!pieceComparer.Equals(x.Pieces[i], y.Pieces[i]))
                    return false;
            }
            return true;
        }

        public int GetHashCode(Cube obj)
        {
            return obj.GetHashCode();
        }
    }
}
