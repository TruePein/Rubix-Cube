using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Piece_Tests
{
    [TestClass]
    public class TurnPieceTests
    {
        public Piece piece;

        [TestInitialize]
        public void CreateCube()
        {
            piece = new CornerPiece();
        }

        [TestMethod]
        public void NoTurnsMakesTheTopSideWhite()
        {
            var expectedColor = Side.Color.White;
            var expectedPosition = Side.Position.Top;
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = Side.Color.Red;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(0, true);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseXAxisTurnMakesTheTopSideOrange()
        {
            var expectedColor = Side.Color.Orange;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(0, false);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseYAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = Side.Color.White;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(1, true);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseYAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = Side.Color.White;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(1, false);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseZAxisTurnMakesTheTopSideGreen()
        {
            var expectedColor = Side.Color.Green;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(2, true);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseZAxisTurnMakesTheTopSideBlue()
        {
            var expectedColor = Side.Color.Blue;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(2, false);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnThenZAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = Side.Color.Red;
            var expectedPosition = Side.Position.Top;
            piece.turnPiece(0, true);
            piece.turnPiece(1, true);
            var actualColor = piece.getSideByPosition(expectedPosition).SideColor;
            var actualPosition = piece.getSideByColor(expectedColor).SidePosition;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
