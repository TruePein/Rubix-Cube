﻿using System;
using System.Collections.Generic;
using Rubix_Cube.Pieces;

namespace Rubix_Cube.IEqualityComparers
{
    public class SideEqualityComparer : IEqualityComparer<Side>
    {
        public bool Equals(Side x, Side y)
        {
            if (x == y)
                throw new ArgumentException($"The two objects both point to the same {x.GetType()} object.");
            if (x.ColorEnum != y.ColorEnum)
                return false;
            if (x.SidePositionEnum != y.SidePositionEnum)
                return false;
            return true;
        }

        public int GetHashCode(Side obj)
        {
            return obj.GetHashCode();
        }
    }
}
