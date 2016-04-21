using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Cube_Tests
{
    [TestClass]
    public class CubeCopyConstructorTests
    {
        private Cube _original;
        private Cube _copy;

        [TestInitialize]
        public void CreateCube()
        {
            _original = new Cube(3);
        }

        [TestMethod]
        public void CopyAndOriginalAreNotTheSame()
        {
            _copy = new Cube(_original);
            Assert.AreNotSame(_copy, _original);
        }

        [TestMethod]
        public void CopyAnOriginalHaveSameMovesIfBothAreNew()
        {
            _copy = new Cube(_original);
            var expected = _original.MovesMade;
            var actual = _copy.MovesMade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CopyAnOriginalHaveSameMovesIfOriginalIsMovedBeforeTheCopyIsMade()
        {
            _original.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            _copy = new Cube(_original);
            var expected = _original.MovesMade;
            var actual = _copy.MovesMade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CopyAnOriginalHaveDifferentMovesIfCopyIsMovedAndOriginalIsNot()
        {
            _copy = new Cube(_original);
            _copy.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            var expected = _original.MovesMade;
            var actual = _copy.MovesMade;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
