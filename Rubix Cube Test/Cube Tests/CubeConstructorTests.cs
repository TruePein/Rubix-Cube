using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;

namespace Rubix_Cube_Test.Cube_Tests
{
    [TestClass]
    public class CubeConstructorTests
    {
        private Cube _cube;

        [TestInitialize]
        public void CreateCube()
        {
            _cube = new Cube();
        }

        [TestMethod]
        public void NewCubeHasMadeZeroMoves()
        {
            var expected = 0;
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewCubeHasSizeOfThree()
        {
            var expected = 3;
            var actual = _cube.Size;
            Assert.AreEqual(expected, actual);
        }
    }
}
