using System.Collections.Generic;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class PieceEqualityComparer : IEqualityComparer<IPiece>
    {
        public bool Equals(IPiece x, IPiece y)
        {
            if (x.Type != y.Type) return false;
            if (x.Coordinates.Item1 != y.Coordinates.Item1) return false;
            if (x.Coordinates.Item2 != y.Coordinates.Item2) return false;
            if (x.Coordinates.Item3 != y.Coordinates.Item3) return false;
            var sideComparer = new SideEqualityComparer();
            for (var i = 0; i < x.NumberOfSides; i++)
            {
                if (!sideComparer.Equals(x.Sides[i], y.Sides[i])) return false;
            }
            return true;
        }

        public int GetHashCode(IPiece obj)
        {
            return obj.GetHashCode();
        }
    }
}
