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
            _cube = new Cube(3);
        }

        [TestMethod]
        public void NewCubeHasMadeZeroMoves()
        {
            var expected = 0;
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
        }
    }
}
