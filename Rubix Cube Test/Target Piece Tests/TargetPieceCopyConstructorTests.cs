using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Target_Piece_Tests
{
    [TestClass]
    public class TargetPieceCopyConstructorTests
    {
        private TargetPiece _original;
        private TargetPiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = new TargetPiece();
            _copy = new TargetPiece(_original);
        }

        [TestMethod]
        public void PiecesAreNotTheSame()
        {
            Assert.AreNotEqual(_original, _copy);
        }

        [TestMethod]
        public void PiecesAreEquivelent()
        {
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(pieceComparer.Equals(_original, _copy));
        }

        [TestMethod]
        public void MovingCopyMakesThePiecesDifferent()
        {
            _copy.Move(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsFalse(pieceComparer.Equals(_original, _copy));
        }


        [TestMethod]
        public void MovingOriginalMakesThePiecesDifferent()
        {
            _original.Move(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsFalse(pieceComparer.Equals(_original, _copy));
        }
    }
}
