using System;
using System.Collections.Generic;

namespace Rubix_Cube.IEqualityComparers
{
    public class CubeFullEqualityComparer : IEqualityComparer<Cube>
    {
        public bool Equals(Cube x, Cube y)
        {
            if (x == y)
                throw new ArgumentException($"The two objects both point to the same {x.GetType()} object.");
            var pieceComparer = new PieceFullEqualityComparer();
            for (var i = 0; i < x.Size; i++)
            {
                for (var j = 0; j < x.Size; j++)
                {
                    for (var k = 0; k < x.Size; k++)
                    {
                        if (!pieceComparer.Equals(x.GetPieceByCoordinates(i, j, k), y.GetPieceByCoordinates(i, j, k)))
                            return false;
                    }
                }
            }
            if (x.Score != y.Score)
                return false;
            if (x.MovesMade != y.MovesMade)
                return false;
            return true;
        }

        public int GetHashCode(Cube obj)
        {
            return obj.GetHashCode();
        }
    }
}
