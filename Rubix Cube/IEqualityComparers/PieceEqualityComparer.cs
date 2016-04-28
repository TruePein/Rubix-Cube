using System;
using System.Collections.Generic;
using System.Linq;
using Rubix_Cube.Enums;
using Rubix_Cube.Pieces;
// ReSharper disable PossibleNullReferenceException

namespace Rubix_Cube.IEqualityComparers
{
    public class PieceEqualityComparer : IEqualityComparer<IPiece>
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
            if (x.TypeEnum != y.TypeEnum)
                return false;

            switch (x.TypeEnum)
            {
                    case PieceTypeEnum.Unseen:
                {
                    return UnseenEquals();
                }
                    case PieceTypeEnum.Middle:
                {
                    return MiddleEquals(x as MiddlePiece, y as MiddlePiece);
                }
                    case PieceTypeEnum.Inner:
                {
                    return InnerEquals(x as InnerPiece, y as InnerPiece);
                }
            }
            var sideComparer = new SideEqualityComparer();
            if (x.Sides.Where((t, i) => !sideComparer.Equals(t, y.Sides[i])).Any())
                return false;
            return true;
        }

        private bool UnseenEquals()
        {
            return true;
        }

        private bool MiddleEquals(MiddlePiece x, MiddlePiece y)
        {
            return x.ColorEnum == y.ColorEnum;
        }

        private bool InnerEquals(InnerPiece x, InnerPiece y)
        {
            return x.ColorEnum == y.ColorEnum;
        }

        public int GetHashCode(IPiece obj)
        {
            return obj.GetHashCode();
        }
    }
}
