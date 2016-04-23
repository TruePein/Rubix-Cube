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
        public void ClockwiseTurnOnZAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesFrontToLeft()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesRightToFront()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesBackToRight()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnZAxisMovesLeftToBack()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesTopToTop()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesFrontToRight()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesRightToBack()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBottomToBottom()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesBackToLeft()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnZAxisMovesLeftToFront()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Z, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesTopToRight()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesFrontToRront()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesRightToBottom()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBottomToLeft()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void ClockwiseTurnOnYAxisMovesLeftToTop()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.Clockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesTopToLeft()
        {
            var side = getSide(0);
            var expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesFrontToFront()
        {
            var side = getSide(1);
            var expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Front;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesRightToTop()
        {
            var side = getSide(2);
            var expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Top;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesBottomToRight()
        {
            var side = getSide(3);
            var expected = SidePositions.Position.Bottom;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Right;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesBackToBack()
        {
            var side = getSide(4);
            var expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
            expected = SidePositions.Position.Back;
            Assert.AreEqual(expected, side.Position);
        }

        [TestMethod]
        public void CounterClockwiseTurnOnYAxisMovesLeftToBottom()
        {
            var side = getSide(5);
            var expected = SidePositions.Position.Left;
            Assert.AreEqual(expected, side.Position);
            side.MoveToNextPosition(Axes.Axis.Y, Directions.Direction.CounterClockwise);
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
