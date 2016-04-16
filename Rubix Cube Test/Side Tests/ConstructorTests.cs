using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Side_Tests
{
    [TestClass]
    public class ConstructorTests
    {
        [TestMethod]
        public void PassingInZeroCreatesATopWhiteSide()
        {
            var side = new Side(0);
            var expectedPosition = Side.Position.Top;
            var expectedColor = Side.Color.White;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInOneCreatesAFrontRedSide()
        {
            var side = new Side(1);
            var expectedPosition = Side.Position.Front;
            var expectedColor = Side.Color.Red;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInTwoCreatesALeftBlueSide()
        {
            var side = new Side(2);
            var expectedPosition = Side.Position.Right;
            var expectedColor = Side.Color.Blue;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInThreeCreatesABottomYellowSide()
        {
            var side = new Side(3);
            var expectedPosition = Side.Position.Bottom;
            var expectedColor = Side.Color.Yellow;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFourCreatesABackOrangePiece()
        {
            var side = new Side(4);
            var expectedPosition = Side.Position.Back;
            var expectedColor = Side.Color.Orange;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFiveCreatesALeftGreenPiece()
        {
            var side = new Side(5);
            var expectedPosition = Side.Position.Left;
            var expectedColor = Side.Color.Green;
            var actualPosition = side.SidePosition;
            var actualColor = side.SideColor;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
