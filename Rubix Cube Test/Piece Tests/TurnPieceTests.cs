using System;
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
