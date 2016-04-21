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
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesFrontToTop()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesRightToRight()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesBottomToFront()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesBackToBottom()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnXAxisMovesLeftToLeft()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesTopToFront()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesFrontToBottom()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesRightToRight()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesBottomToBack()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesBackToTop()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesLeftToLeft()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.X, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesFrontToLeft()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesRightToFront()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBackToRight()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesLeftToBack()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesFrontToRight()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesRightToBack()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnXAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesBackToLeft()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesLeftToFront()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesTopToRight()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesFrontToRront()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesRightToBottom()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBottomToLeft()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesLeftToTop()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesTopToLeft()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesFrontToFront()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesRightToTop()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBottomToRight()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesLeftToBottom()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        private Side getSide(int i)
        {
            switch (i)
            {
                case 0:
                    {
                        return new Side(Colors.Color.White, SidePositions.Position.Top);
                    }
                case 1:
                    {
                        return new Side(Colors.Color.Red, SidePositions.Position.Front);
                    }
                case 2:
                    {
                        return new Side(Colors.Color.Blue, SidePositions.Position.Right);
                    }
                case 3:
                    {
                        return new Side(Colors.Color.Yellow, SidePositions.Position.Bottom);
                    }
                case 4:
                    {
                        return new Side(Colors.Color.Orange, SidePositions.Position.Back);
                    }
                default:
                    {
                        return new Side(Colors.Color.Green, SidePositions.Position.Left);
                    }
            }
        }
    }
}
