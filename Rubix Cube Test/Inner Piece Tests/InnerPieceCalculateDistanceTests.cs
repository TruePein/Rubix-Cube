using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class InnerPieceCalculateDistanceTests
    {
        private static TargetPiece _target;

        [ClassInitialize()]
        public static void InitializeTests(TestContext context)
        {
            _target = new TargetPiece();
        }

        [TestMethod]
        public void NewMiddlePieceHasADistanceofZero()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 0;
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteCounterClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteClockWiseZTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteCounterClockWiseZTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteCounterClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.White);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedCounterClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedCounterClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedClockWiseYTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedCounterClockWiseYTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Red);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueClockWiseXTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 0;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueCounterClockWiseXTurnHasADistanceOZero()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 0;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueCounterClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BlueCounterClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Blue);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowCounterClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowClockWiseZTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowCounterClockWiseZTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YellowCounterClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Yellow);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeCounterClockWiseXTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 1;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeCounterClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeClockWiseYTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrangeCounterClockWiseYTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Orange);
            var expected = 0;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenClockWiseXTurnHasADistanceOfZero()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 0;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenCounterClockWiseXTurnHasADistanceOZero()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 0;
            piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenCounterClockWiseYTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GreenCounterClockWiseZTurnHasADistanceOfOne()
        {
            var piece = getInnerPiece(ColorEnum.Green);
            var expected = 1;
            piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = piece.CalculateDistance(_target);
            Assert.AreEqual(expected, actual);
        }

        private InnerPiece getInnerPiece(ColorEnum colorEnum)
        {
            return new InnerPiece(0, 0, 0, colorEnum);
        }
    }
}