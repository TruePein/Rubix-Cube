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
            var side = new Side(ColorEnum.White, SidePositionEnum.Top);
            var expectedPosition = SidePositionEnum.Top;
            var expectedColor = ColorEnum.White;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInOneCreatesAFrontRedSide()
        {
            var side = new Side(ColorEnum.Red, SidePositionEnum.Front);
            var expectedPosition = SidePositionEnum.Front;
            var expectedColor = ColorEnum.Red;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInTwoCreatesALeftBlueSide()
        {
            var side = new Side(ColorEnum.Blue, SidePositionEnum.Right);
            var expectedPosition = SidePositionEnum.Right;
            var expectedColor = ColorEnum.Blue;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInThreeCreatesABottomYellowSide()
        {
            var side = new Side(ColorEnum.Yellow, SidePositionEnum.Bottom);
            var expectedPosition = SidePositionEnum.Bottom;
            var expectedColor = ColorEnum.Yellow;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFourCreatesABackOrangePiece()
        {
            var side = new Side(ColorEnum.Orange, SidePositionEnum.Back);
            var expectedPosition = SidePositionEnum.Back;
            var expectedColor = ColorEnum.Orange;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }

        [TestMethod]
        public void PassingInFiveCreatesALeftGreenPiece()
        {
            var side = new Side(ColorEnum.Green, SidePositionEnum.Left);
            var expectedPosition = SidePositionEnum.Left;
            var expectedColor = ColorEnum.Green;
            var actualPosition = side.SidePositionEnum;
            var actualColor = side.ColorEnum;
            Assert.AreEqual(expectedPosition, actualPosition);
            Assert.AreEqual(expectedColor, actualColor);
        }
    }
}
