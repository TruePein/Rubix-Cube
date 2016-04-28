using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class InnerPieceCopyConstructorTests
    {
        private InnerPiece _original;
        private InnerPiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = new InnerPiece(1, 1, 0, ColorEnum.White);
            _copy = new InnerPiece(_original);
        }

        [TestMethod]
        public void PiecesAreDifferent()
        {
            Assert.AreNotEqual(_original, _copy);
        }

        [TestMethod]
        public void PiecesAreEquivelent()
        {
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(pieceComparer.Equals(_original, _copy));
        }
    }
}
