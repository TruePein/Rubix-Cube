using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Edge_Piece_Tests
{
    [TestClass]
    public class EdgePieceCopyConstructorTests
    {
        private EdgePiece _original;
        private EdgePiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = new EdgePiece(1, 0, 0);
            _copy = new EdgePiece(_original);
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
