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
            var cubeComparer = new CubePiecesEqualityComparer();
            Assert.IsTrue(cubeComparer.Equals(_original, _copy));
        }
    }
}
