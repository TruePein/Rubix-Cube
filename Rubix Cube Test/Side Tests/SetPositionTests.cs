using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Side_Tests
{
    [TestClass]
    public class SetPositionTests
    {
        static Side side;

        [ClassInitialize]
        public static void MakeSide(TestContext context)
        {
            side = new Side(0);
        }

        [TestMethod]
        public void SettingToTopMakesThePositionTop()
        {
            var expected = Side.Position.Top;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToTopMakesThePositionNothingElse()
        {
            var position = Side.Position.Top;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Back, actual);
            Assert.AreNotEqual(Side.Position.Bottom, actual);
            Assert.AreNotEqual(Side.Position.Front, actual);
            Assert.AreNotEqual(Side.Position.Left, actual);
            Assert.AreNotEqual(Side.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToFrontMakesThePositionFront()
        {
            var expected = Side.Position.Front;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToFrontMakesThePositionNothingElse()
        {
            var position = Side.Position.Front;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Back, actual);
            Assert.AreNotEqual(Side.Position.Bottom, actual);
            Assert.AreNotEqual(Side.Position.Top, actual);
            Assert.AreNotEqual(Side.Position.Left, actual);
            Assert.AreNotEqual(Side.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToRightMakesThePositionRight()
        {
            var expected = Side.Position.Right;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToRightMakesThePositionNothingElse()
        {
            var position = Side.Position.Right;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Back, actual);
            Assert.AreNotEqual(Side.Position.Bottom, actual);
            Assert.AreNotEqual(Side.Position.Front, actual);
            Assert.AreNotEqual(Side.Position.Left, actual);
            Assert.AreNotEqual(Side.Position.Top, actual);
        }

        [TestMethod]
        public void SettingToBottomMakesThePositionBottom()
        {
            var expected = Side.Position.Bottom;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToBotomMakesThePositionNothingElse()
        {
            var position = Side.Position.Bottom;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Back, actual);
            Assert.AreNotEqual(Side.Position.Top, actual);
            Assert.AreNotEqual(Side.Position.Front, actual);
            Assert.AreNotEqual(Side.Position.Left, actual);
            Assert.AreNotEqual(Side.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToBackMakesThePositionBack()
        {
            var expected = Side.Position.Back;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToBackMakesThePositionNothingElse()
        {
            var position = Side.Position.Back;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Top, actual);
            Assert.AreNotEqual(Side.Position.Bottom, actual);
            Assert.AreNotEqual(Side.Position.Front, actual);
            Assert.AreNotEqual(Side.Position.Left, actual);
            Assert.AreNotEqual(Side.Position.Right, actual);
        }

        [TestMethod]
        public void SettingToLeftMakesThePositionLeft()
        {
            var expected = Side.Position.Left;
            side.SidePosition = expected;
            var actual = side.SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SettingToLeftMakesThePositionNothingElse()
        {
            var position = Side.Position.Left;
            side.SidePosition = position;
            var actual = side.SidePosition;
            Assert.AreNotEqual(Side.Position.Back, actual);
            Assert.AreNotEqual(Side.Position.Bottom, actual);
            Assert.AreNotEqual(Side.Position.Front, actual);
            Assert.AreNotEqual(Side.Position.Top, actual);
            Assert.AreNotEqual(Side.Position.Right, actual);
        }
    }
}
