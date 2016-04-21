using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
    [TestClass]
    public class PieceTurnPieceTests
    {
        private Piece _piece;

        [TestInitialize]
        public void CreateCube()
        {
            _piece = new CornerPiece(0,0,0);
        }

        [TestMethod]
        public void NoTurnsMakesTheTopSideWhite()
        {
            var expectedColor = Colors.Color.White;
            var expectedPosition = SidePositions.Position.Top;
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = Colors.Color.Red;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseXAxisTurnMakesTheTopSideOrange()
        {
            var expectedColor = Colors.Color.Orange;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseYAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = Colors.Color.White;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseYAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = Colors.Color.White;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseZAxisTurnMakesTheTopSideGreen()
        {
            var expectedColor = Colors.Color.Green;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseZAxisTurnMakesTheTopSideBlue()
        {
            var expectedColor = Colors.Color.Blue;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnThenZAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = Colors.Color.Red;
            var expectedPosition = SidePositions.Position.Top;
            _piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            _piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).Color;
            var actualPosition = _piece.GetSideByColor(expectedColor).Position;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
