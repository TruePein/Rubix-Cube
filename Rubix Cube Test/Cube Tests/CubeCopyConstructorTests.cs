using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Cube_Tests
{
    [TestClass]
    public class CubeCopyConstructorTests
    {
        private readonly Cube _original = new Cube();
        private Cube _copy;

        [TestInitialize]
        public void CreateCube()
        {
            _copy = new Cube(_original);
        }

        [TestMethod]
        public void CopyAndOriginalAreNotTheSame()
        {
            Assert.AreNotSame(_copy, _original);
        }

        [TestMethod]
        public void CopyAndOriginalAreIdentical()
        {
            var cubeComparer = new CubeFullEqualityComparer();
            Assert.IsTrue(cubeComparer.Equals(_original, _copy));
        }

        [TestMethod]
        public void CopyAndOriginalAreDifferentIfCopyIsMovedAndOriginalIsNot()
        {
            _copy.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            var cubeComparer = new CubeFullEqualityComparer();
            Assert.IsFalse(cubeComparer.Equals(_original, _copy));
        }

        [TestMethod]
        public void CopyAndOriginalHaveDifferentMovesIfOriginalIsMovedAndCopyIsNot()
        {
            _original.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            var expected = _original.MovesMade;
            var actual = _copy.MovesMade;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
