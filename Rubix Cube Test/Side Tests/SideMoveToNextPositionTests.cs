using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Side_Tests
{
    [TestClass]
    public class SideMoveToNextPositionTests
    {
        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesTopToBack()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesFrontToTop()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesRightToRight()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesBottomToFront()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesBackToBottom()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesLeftToLeft()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesTopToFront()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesFrontToBottom()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesRightToRight()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesBottomToBack()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesBackToTop()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesLeftToLeft()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.X, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesFrontToLeft()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesRightToFront()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBackToRight()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesLeftToBack()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesFrontToRight()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesRightToBack()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBackToLeft()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesLeftToFront()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Z, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesTopToRight()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesFrontToRront()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesRightToBottom()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBottomToLeft()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesLeftToTop()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.Clockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesTopToLeft()
        {
            var side = getSide(0);
            var expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesFrontToFront()
        {
            var side = getSide(1);
            var expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Front;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesRightToTop()
        {
            var side = getSide(2);
            var expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Top;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesBottomToRight()
        {
            var side = getSide(3);
            var expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Right;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Back;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesLeftToBottom()
        {
            var side = getSide(5);
            var expected = SidePositionEnum.Left;
            Assert.AreEqual(expected, side.SidePositionEnum);
            side.MoveToNextPosition(AxisEnum.Y, DirectionEnum.CounterClockwise);
            expected = SidePositionEnum.Bottom;
            Assert.AreEqual(expected, side.SidePositionEnum);
        }

        private Side getSide(int i)
        {
            switch (i)
            {
                case 0:
                    {
                        return new Side(ColorEnum.White, SidePositionEnum.Top);
                    }
                case 1:
                    {
                        return new Side(ColorEnum.Red, SidePositionEnum.Front);
                    }
                case 2:
                    {
                        return new Side(ColorEnum.Blue, SidePositionEnum.Right);
                    }
                case 3:
                    {
                        return new Side(ColorEnum.Yellow, SidePositionEnum.Bottom);
                    }
                case 4:
                    {
                        return new Side(ColorEnum.Orange, SidePositionEnum.Back);
                    }
                default:
                    {
                        return new Side(ColorEnum.Green, SidePositionEnum.Left);
                    }
            }
        }
    }
}
