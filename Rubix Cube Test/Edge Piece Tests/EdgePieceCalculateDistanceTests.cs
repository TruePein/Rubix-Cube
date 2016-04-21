using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Edge_Piece_Tests
{
    [TestClass]
    public class EdgePieceCalculateDistanceTests
    {
        private static TargetPiece _target;

        EdgePiece _piece;

        [ClassInitialize()]
        public static void InitializeTests(TestContext context)
        {
            _target = new TargetPiece();
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            _piece = new EdgePiece(1, 0, 0);
        }

        [TestMethod]
        public void NewEdgePieceHasADistanceOfZero()
        {
            var expected = 0;
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceCounterClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceCounterClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceCounterClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceAndBackHasADistanceOfZero()
        {
            var expected = 0;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedOnceOnOneAxisAndOnceOnAnotherAxisHasADistanceOfTwo()
        {
            var expected = 2;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedTwiceInTheSameDirectionHasADistanceOfTwo()
        {
            var expected = 2;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedThriceInTheSameDirectionHasADistanceOfOne()
        {
            var expected = 1;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedTwiceInTheSameDirectionAndOnceOnADifferentAxisHasADistanceOfThree()
        {
            var expected = 3;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EdgePieceTurnedFourTimesInTheSameDirectionHasADistanceOfTwo()
        {
            var expected = 0;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = _piece.CalculateDistance(_target);
            Assert.AreEqual(expected, result);
        }
    }
}