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
            var expectedColor = ColorEnum.White;
            var expectedPosition = SidePositionEnum.Top;
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = ColorEnum.Red;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseXAxisTurnMakesTheTopSideOrange()
        {
            var expectedColor = ColorEnum.Orange;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseZAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = ColorEnum.White;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseZAxisTurnMakesTheTopSideWhite()
        {
            var expectedColor = ColorEnum.White;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseYAxisTurnMakesTheTopSideGreen()
        {
            var expectedColor = ColorEnum.Green;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void CounterClockwiseYAxisTurnMakesTheTopSideBlue()
        {
            var expectedColor = ColorEnum.Blue;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }

        [TestMethod]
        public void ClockwiseXAxisTurnThenZAxisTurnMakesTheTopSideRed()
        {
            var expectedColor = ColorEnum.Red;
            var expectedPosition = SidePositionEnum.Top;
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actualColor = _piece.GetSideByPosition(expectedPosition).ColorEnum;
            var actualPosition = _piece.GetSideByColor(expectedColor).SidePositionEnum;
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expectedPosition, actualPosition);
        }
    }
}
