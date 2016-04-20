using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Side_Tests
{
    [TestClass]
    public class SetPositionTests
    {
        static Side side;

        [ClassInitialize]
        public static void MakeSide(TestContext context)
        {
            side = new Side(Colors.Color.White, SidePositions.Position.Top);
        }

        [TestMethod]
        public void SettingToTopMakesThePositionTop()
        {
            var expected = SidePositions.Position.Top;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToTopMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Top;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Back, actual);
            Assert.AreNotEqual(SidePositions.Position.Bottom, actual);
            Assert.AreNotEqual(SidePositions.Position.Front, actual);
            Assert.AreNotEqual(SidePositions.Position.Left, actual);
            Assert.AreNotEqual(SidePositions.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToFrontMakesThePositionFront()
        {
            var expected = SidePositions.Position.Front;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToFrontMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Front;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Back, actual);
            Assert.AreNotEqual(SidePositions.Position.Bottom, actual);
            Assert.AreNotEqual(SidePositions.Position.Top, actual);
            Assert.AreNotEqual(SidePositions.Position.Left, actual);
            Assert.AreNotEqual(SidePositions.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToRightMakesThePositionRight()
        {
            var expected = SidePositions.Position.Right;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToRightMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Right;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Back, actual);
            Assert.AreNotEqual(SidePositions.Position.Bottom, actual);
            Assert.AreNotEqual(SidePositions.Position.Front, actual);
            Assert.AreNotEqual(SidePositions.Position.Left, actual);
            Assert.AreNotEqual(SidePositions.Position.Top, actual);
        }

        [TestMethod]
        public void SettingToBottomMakesThePositionBottom()
        {
            var expected = SidePositions.Position.Bottom;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToBotomMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Bottom;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Back, actual);
            Assert.AreNotEqual(SidePositions.Position.Top, actual);
            Assert.AreNotEqual(SidePositions.Position.Front, actual);
            Assert.AreNotEqual(SidePositions.Position.Left, actual);
            Assert.AreNotEqual(SidePositions.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToBackMakesThePositionBack()
        {
            var expected = SidePositions.Position.Back;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToBackMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Back;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Top, actual);
            Assert.AreNotEqual(SidePositions.Position.Bottom, actual);
            Assert.AreNotEqual(SidePositions.Position.Front, actual);
            Assert.AreNotEqual(SidePositions.Position.Left, actual);
            Assert.AreNotEqual(SidePositions.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToLeftMakesThePositionLeft()
        {
            var expected = SidePositions.Position.Left;
            side.Position = expected;
            var actual = side.Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToLeftMakesThePositionNothingElse()
        {
            var position = SidePositions.Position.Left;
            side.Position = position;
            var actual = side.Position;
            Assert.AreNotEqual(SidePositions.Position.Back, actual);
            Assert.AreNotEqual(SidePositions.Position.Bottom, actual);
            Assert.AreNotEqual(SidePositions.Position.Front, actual);
            Assert.AreNotEqual(SidePositions.Position.Top, actual);
            Assert.AreNotEqual(SidePositions.Position.Right, actual);
        }
    }
}
