using System;
using System.Collections.Generic;
using System.Linq;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class PieceEqualityComparer : IEqualityComparer<IPiece>
    {
        public bool Equals(IPiece x, IPiece y)
        {
            if (x == y)
                throw new ArgumentException($"The two objects both point to the same {x.GetType()} object.");
            var sideComparer = new SideEqualityComparer();
            if (x.Sides.Where((t, i) => !sideComparer.Equals(t, y.Sides[i])).Any())
                return false;
            if (x.Type != y.Type) return false;
            if (x.Coordinates.Item1 != y.Coordinates.Item1)
                return false;
            if (x.Coordinates.Item2 != y.Coordinates.Item2)
                return false;
            if (x.Coordinates.Item3 != y.Coordinates.Item3)
                return false;
            return true;
        }

        public int GetHashCode(IPiece obj)
        {
            return obj.GetHashCode();
        }
    }
}
