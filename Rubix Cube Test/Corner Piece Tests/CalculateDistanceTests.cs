using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Corner_Piece_Tests
{
    [TestClass]
    public class CalculateDistanceTests
    {
        public static TargetPiece target;

        CornerPiece piece;

        [ClassInitialize()]
        public static void InitializeTests(TestContext context)
        {
            target = new TargetPiece();
        }

        [TestInitialize()]
        public void InitializeTest()
        {
            piece = new CornerPiece(0,0,0);
        }

        [TestMethod]
        public void NewCornerPieceHasADistanceOfZero()
        {
            var expected = 0;
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnXAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnYAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceCounterClockwiseOnZAxisHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceAndBackHasADistanceOfZero()
        {
            var expected = 0;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedOnceOnOneAxisAndOnceOnAnotherAxisHasADistanceOfTwo()
        {
            var expected = 2;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedTwiceInTheSameDirectionHasADistanceOfTwo()
        {
            var expected = 2;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedThriceInTheSameDirectionHasADistanceOfOne()
        {
            var expected = 1;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedTwiceInTheSameDirectionAndOnceOnADifferentAxisHasADistanceOfThree()
        {
            var expected = 3;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CornerPieceTurnedFourTimesInTheSameDirectionHasADistanceOfTwo()
        {
            var expected = 0;
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var result = piece.CalculateDistance(target);
            Assert.AreEqual(expected, result);
        }
    }
}
