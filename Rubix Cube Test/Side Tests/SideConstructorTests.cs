using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Side_Tests
{
    [TestClass]
    public class SideConstructorTests
    {
        [TestMethod]
        public void PassingInZeroCreatesATopWhiteSide()
        {
            var side = new Side(Colors.Color.White, SidePositions.Position.Top);
            var expectedPosition = SidePositions.Position.Top;
            var expectedColor = Colors.Color.White;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInOneCreatesAFrontRedSide()
        {
            var side = new Side(Colors.Color.Red, SidePositions.Position.Front);
            var expectedPosition = SidePositions.Position.Front;
            var expectedColor = Colors.Color.Red;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInTwoCreatesALeftBlueSide()
        {
            var side = new Side(Colors.Color.Blue, SidePositions.Position.Right);
            var expectedPosition = SidePositions.Position.Right;
            var expectedColor = Colors.Color.Blue;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInThreeCreatesABottomYellowSide()
        {
            var side = new Side(Colors.Color.Yellow, SidePositions.Position.Bottom);
            var expectedPosition = SidePositions.Position.Bottom;
            var expectedColor = Colors.Color.Yellow;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFourCreatesABackOrangePiece()
        {
            var side = new Side(Colors.Color.Orange, SidePositions.Position.Back);
            var expectedPosition = SidePositions.Position.Back;
            var expectedColor = Colors.Color.Orange;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFiveCreatesALeftGreenPiece()
        {
            var side = new Side(Colors.Color.Green, SidePositions.Position.Left);
            var expectedPosition = SidePositions.Position.Left;
            var expectedColor = Colors.Color.Green;
            var actualPosition = side.Position;
            var actualColor = side.Color;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
