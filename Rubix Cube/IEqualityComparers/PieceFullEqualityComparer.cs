using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class PieceFullEqualityComparer : IEqualityComparer<IPiece>
    {
        public bool Equals(IPiece x, IPiece y)
        {
            if (x == y)
                throw new ArgumentException($"The two objects both point to the same {x.GetType()} object.");
            if (x.Coordinates.Item1 != y.Coordinates.Item1)
                throw new ArgumentException("The two pieces aren't in the same place.");
            if (x.Coordinates.Item2 != y.Coordinates.Item2)
                throw new ArgumentException("The two pieces aren't in the same place.");
            if (x.Coordinates.Item3 != y.Coordinates.Item3)
                throw new ArgumentException("The two pieces aren't in the same place.");
            var sideComparer = new SideEqualityComparer();
            for (var i = 0; i < x.Sides.Count; i++)
            {
                if (!sideComparer.Equals(x.Sides[i], y.Sides[i]))
                    return false;
            }
            return true;
        }

        public int GetHashCode(IPiece obj)
        {
            return obj.GetHashCode();
        }
    }
}
