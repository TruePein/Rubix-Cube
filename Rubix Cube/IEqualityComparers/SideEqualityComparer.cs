using System.Collections.Generic;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class SideEqualityComparer : IEqualityComparer<Side>
    {
        public bool Equals(Side x, Side y)
        {
            if (x.Color != y.Color) return false;
            if (x.Position != y.Position) return false;
            return true;
        }

        public int GetHashCode(Side obj)
        {
            return obj.GetHashCode();
        }
    }
}
