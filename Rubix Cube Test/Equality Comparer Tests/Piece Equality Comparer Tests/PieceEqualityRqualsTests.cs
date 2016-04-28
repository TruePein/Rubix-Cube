using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Equality_Comparer_Tests.Piece_Equality_Comparer_Tests
{
    [TestClass]
    public class PieceEqualityEqualsTests
    {
        private static PieceEqualityComparer _comparer;

        [ClassInitialize]
        public static void CreateComparer(TestContext context)
        {
            _comparer = new PieceEqualityComparer();
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingACornerPieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingACornerPieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingACornerPieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingACornerWithAMovedPieceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingCornerAgainstItselfMovedBackButInADifferentOrientationReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            copy.Move(AxisEnum.Z, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingCornerAgainstADifferentPieceInTheSamePositionReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 0, 0, 3);
            var other = PieceFactory.GetPiece(0, 0, 2, 3);
            other.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, other));
        }
    }
}
