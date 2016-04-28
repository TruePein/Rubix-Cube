using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Enums;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Corner_Piece_Tests
{
    [TestClass]
    public class CornerPieceCalculateDistanceTests
    {
        private static TargetPiece _target;

        private CornerPiece _piece;

        [ClassInitialize]
        public static void InitializeTests(TestContext context)
        {
            _target = new TargetPiece();
        }

        [TestInitialize]
        public void InitializeTest()
        {
            _piece = new CornerPiece(0,0,0);
        }

        [TestMethod]
        public void NewCornerPieceHasADistanceOfZero()
        {
            var expected = 0;
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceAndBackHasADistanceOfZero()
        {
            var expected = 0;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceOnOneAxisAndOnceOnAnotherAxisHasADistanceOfTwo()
        {
            var expected = 2;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedTwiceInTheSameDirectionHasADistanceOfTwo()
        {
            var expected = 2;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedThriceInTheSameDirectionHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedTwiceInTheSameDirectionAndOnceOnADifferentAxisHasADistanceOfThree()
        {
            var expected = 3;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedFourTimesInTheSameDirectionHasADistanceOfZero()
        {
            var expected = 0;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }
    }
}
