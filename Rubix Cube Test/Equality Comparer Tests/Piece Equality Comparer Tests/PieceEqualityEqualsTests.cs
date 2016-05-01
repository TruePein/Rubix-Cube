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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnEdgePieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnEdgePieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingAnEdgePieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnEdgeWithAMovedPieceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnEdgeAgainstItselfMovedBackButInADifferentOrientationReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.X, DirectionEnum.CounterClockwise, 3);
            copy.Move(AxisEnum.Z, DirectionEnum.Clockwise, 3);
            copy.Move(AxisEnum.Y, DirectionEnum.CounterClockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnEdgeAgainstADifferentPieceInTheSamePositionReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 0, 1, 3);
            var other = PieceFactory.GetPiece(0, 1, 2, 3);
            other.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, other));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAMiddlePieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAMiddlePieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingAMiddlePieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAMiddleWithAMovedPieceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAMiddleAgainstItselfMovedBackButInADifferentOrientationReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 3);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            copy.Move(AxisEnum.Z, DirectionEnum.CounterClockwise, 3);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAMiddleAgainstADifferentPieceInTheSamePositionReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 3);
            var other = PieceFactory.GetPiece(1, 1, 2, 3);
            other.Move(AxisEnum.Y, DirectionEnum.CounterClockwise, 3);
            Assert.IsFalse(_comparer.Equals(piece, other));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnInnerPieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnInnerPieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingAnInnerPieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnInnerWithAMovedPieceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnInnerAgainstItselfMovedBackButInADifferentOrientationReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 4);
            copy.Move(AxisEnum.Z, DirectionEnum.CounterClockwise, 4);
            copy.Move(AxisEnum.X, DirectionEnum.CounterClockwise, 4);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnInnerAgainstAnotherInnerofTheSameColorInTheSamePositionReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var other = PieceFactory.GetPiece(0, 1, 2, 4);
            other.Move(AxisEnum.X, DirectionEnum.Clockwise, 4);
            Assert.IsTrue(_comparer.Equals(piece, other));
        }

        [TestMethod]
        public void ComparingAnInnerAgainstADifferentPieceInTheSamePositionReturnsFalse()
        {
            var piece = PieceFactory.GetPiece(0, 1, 1, 4);
            var other = PieceFactory.GetPiece(1, 1, 3, 4);
            other.Move(AxisEnum.Y, DirectionEnum.CounterClockwise, 4);
            Assert.IsFalse(_comparer.Equals(piece, other));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnUnseenPieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnUnseenPieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingAnUnseenPieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingAnUnseenWithAMovedPieceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnUnseenAgainstItselfMovedBackButInADifferentOrientationReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            var copy = PieceFactory.GetPiece(piece);
            copy.Move(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 4);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingAnUnseenAgainstADifferentPieceInTheSamePositionReturnsTrue()
        {
            var piece = PieceFactory.GetPiece(1, 1, 1, 4);
            var other = PieceFactory.GetPiece(1, 1, 2, 4);
            other.Move(AxisEnum.Y, DirectionEnum.CounterClockwise, 4);
            Assert.IsTrue(_comparer.Equals(piece, other));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingATargetPieceWithItselfThrowsAnError()
        {
            var piece = PieceFactory.GetPiece();
            Assert.IsTrue(_comparer.Equals(piece, piece));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingATargetPieceWithSameReferenceThrowsAnError()
        {
            var piece = PieceFactory.GetPiece();
            var same = piece;
            Assert.IsTrue(_comparer.Equals(piece, same));
        }

        [TestMethod]
        public void ComparingATargetPieceWithACopyReturnsTrue()
        {
            var piece = PieceFactory.GetPiece();
            var copy = PieceFactory.GetPiece(piece);
            Assert.IsTrue(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        public void ComparingATargetAgainstItselfButInADifferentOrientationReturnsFalse()
        {
            var piece = PieceFactory.GetPiece();
            var copy = PieceFactory.GetPiece(piece);
            copy.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            Assert.IsFalse(_comparer.Equals(piece, copy));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingTwoDifferentTypesInTheSamePositionThrowsAnError()
        {
            var corner = PieceFactory.GetPiece(0, 0, 0, 3);
            var target = PieceFactory.GetPiece();
            Assert.IsFalse(_comparer.Equals(corner, target));
        }
    }
}
